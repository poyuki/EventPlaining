using System;
using System.Diagnostics.Tracing;
using System.Linq;
using EventPlaining.Models;
using EventPlaining.Models.Session;
using EventPlaining.ViewModel;
using EventPlaining.ViewModel.UserViewModels;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using Newtonsoft.Json.Linq;

namespace EventPlaining.Controllers
{
    public class UserController : BaseController
    {
        public UserController(EventPlainingDBContext dbContext) : base(dbContext)
        {
        }
        // GET
        public IActionResult Registration()
        {
            RegistrationViewModel rvm=new RegistrationViewModel(true,"",GetUserInSession());
            
            return View(rvm);
        }
        
        public JObject FollowEvent(long id)
        {
            return JObject.Parse("");;
        }
        
        public IActionResult SendSubmitEmail(NotSubmitedUser notSubmitedUser)
        {
            string viewMessage;
            bool succesStatus;
            try
            {
                _db.NotSubmitedUsers.Add(notSubmitedUser);
                _db.SaveChanges();
                viewMessage =
                    "На указанный эелектронный почтовый ящик отправленно письмо с сылкой для подверждения регистрации на мероприятие!";
                succesStatus = true;
                
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Админ", "Amin@mail.com"));
                message.To.Add(new MailboxAddress("Новый пользователь", notSubmitedUser.Email));
                message.Subject = "Подтвержление регистрации";
                
                string linkToEvent = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
                
                message.Body = new TextPart("plain")
                {
                    Text= $@"Приветствую вас {notSubmitedUser.LogInName}!
Вый зарегестрировались на одно из меропритий в нашей системе.
Пожалуйста, подтвердите регистрацию перейдя по ссылке {linkToEvent}/User/SubmitRegistration?id={notSubmitedUser.Id}"
                };
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate ("testmailpoyu@gmail.com", "123993pki");

                    client.Send (message);
                    client.Disconnect (true);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                viewMessage="При регистрации на мероприятие произошла ошибка!";
                succesStatus = false;
            }
            SendSubmitEmailViewModel ssevm=new SendSubmitEmailViewModel(succesStatus,viewMessage,GetUserInSession());
            
            
            return View(ssevm);
        }
        
        public IActionResult SubmitRegistration(long id)
        {
            NotSubmitedUser notSubmitedUser = _db.NotSubmitedUsers.Find(id);
            string message;
            bool succesStatus;            
            try
            {
                User user = new User();
                user.SubmitUser(notSubmitedUser);
                _db.Users.Add(user);
                _db.NotSubmitedUsers.Remove(notSubmitedUser);
                _db.SaveChanges();
                message="Регистрация прошла успешно.";
                succesStatus = true;
            }
            catch (Exception e)
            {
                message= "При подтверждении регистрация произошел сбой, пожалуйста попробуйте позже";
                succesStatus = false;
                Console.WriteLine(e);
            }
            SubmitRegistrationViewModel srvm=new SubmitRegistrationViewModel(message,succesStatus,GetUserInSession());
            
            return View(srvm);
        }
        
        public IActionResult LoginForm(string failureData)
        {
            bool successStatus;
            string message;
            if (failureData == null)
            {
                successStatus = true;
                message = "Успех";
            }
            else
            {
                successStatus = false;
                switch (failureData)
                {
                    case "login":
                        message = "Ошибка входа в систему. Неверный логин";
                        break;
                    case "password":
                        message = "Ошибка входа в систему. Неверный пароль";
                        break;
                    default:
                        message = "Ошибка входа в систему. Причина которой неизвестна";
                        break;
                }
            }
            LoginFormViewModel lfvm= new LoginFormViewModel(successStatus,message,GetUserInSession());
            
            return View(lfvm);
        }
        
        [HttpPost]
        public IActionResult Login(string login,string password)
        {
            try
            {
                
                if (_db.Users.Any(u=>u.LogInName==login))
                {
                    User user=_db.Users.First(f => f.LogInName == login);
                    if (user.Password == password)
                    {
                        UserSession userInSession = new UserSession(user);
                        HttpContext.Session.Set<UserSession>("userInSession", userInSession);
                        return Redirect("~/Home/Index");    
                    }
                    else
                    {
                        return Redirect($"~/User/LoginForm?failureData=password");    
                    }
                }
                else
                {
                    return Redirect($"~/User/LoginForm?failureData=login");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Redirect("~/Home/Error");
            }
        }

        public IActionResult Logout()
        {
            UserSession logoutUserInSession = new UserSession();
            HttpContext.Session.Set<UserSession>("userInSession", logoutUserInSession);
            return Redirect("~/Home/Index");
        }
        
        public IActionResult Profile()
        {
            UserSession userInSession = GetUserInSession();
            if (userInSession.LogedIn)
            {
                string message;
                ProfileViewModel pvm;
                try
                {
                    User user = _db.Users.Include(u => u.Profile).Single(u => u.Id == userInSession.Id);
                    message = "Все отлично вот ваши профиль!";
                    pvm = new ProfileViewModel(true, message, GetUserInSession(), user);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    message =
                        "К сожалению ваш профиль не найден. Мы взяли эту проблему на карандаш и будем решать ее в первую очеред.!";
                    pvm = new ProfileViewModel(false, message, GetUserInSession());
                }

                return View(pvm);
            }
            else
            {
                return Redirect("~/User/Login");
            }
            
        }

        public IActionResult EditUser(long id)
        {
            UserSession userInSession = GetUserInSession();
            if (userInSession.LogedIn)
            {
                string message;
                EditUserViewModel euvm;
                try
                {
                    User user = _db.Users.Include(u => u.Profile).Single(u => u.Id == id);
                    message = "Вот ваш профиль для редактирвания";
                    euvm = new EditUserViewModel(true, message, userInSession, user);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    message = "При попытке открытия вашего профиля для редактирования возникла ошибка";
                    euvm = new EditUserViewModel(false, message, userInSession);
                }

                return View(euvm);
            }
            else
            {
                return Redirect("~/User/Login");
            }
        }

        public IActionResult EditProfile(long id)
        {
            UserSession userInSession = GetUserInSession();
            if (userInSession.LogedIn)
            {
                string message;
                EditProfileViewModel edvm;
                try
                {
                    Profile profile = _db.Profiles.Single(p => p.Id == id);
                    message = "Вот ваш профиль для редактирвания";
                    edvm = new EditProfileViewModel(true, message, userInSession, profile);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    message = "При попытке открытия вашего профиля для редактирования возникла ошибка";
                    edvm = new EditProfileViewModel(false, message, userInSession);
                }

                return View(edvm);
            }
            else
            {
                return Redirect("~/User/Login");
            }
        }
        [HttpPost]
        public IActionResult SubmitEditProfile(Profile profile)
        {
            try
            {
                _db.Profiles.Update(profile);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return Redirect("~/User/Profile");
        }
        
        [HttpPost]
        public IActionResult SubmitEditUser(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
            
            return Redirect("~/User/Profile");
        }
    }
}