// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function openModal() {
    let modal=$('#modal');
    $('#overlay').show();
    modal.css({
        'display':'flex',
        'margin-top':`-${modal.height()/2}px`,
        'margin-left':`-${modal.width()/2}px`
    });

}
function hideModal() {
    $('#overlay').hide();
    $('#modal').hide();
    $('#modal-body input').val('');
}

function submitModal() {
    let val=($('#modal-body input').val()).trim(),html,
        id=$('form div:last')[0].id,idVal=id===''?0:parseInt(id);
    if (val!==''){
        html = `<div id="${idVal++}" class="params"><label for="pram-name-${idVal++}">${val}:</label> <input id="pram-name-${idVal++}">
                <i class="fas fa-minus" onclick="deleteParam(event)"></i></div>`;
        $('#forForm i.fa-plus').before(html);
    }
    hideModal()
}
function deleteParam(ev) {
    let el=$(ev.currentTarget).closest('div');
    el.remove()
}

function submitForm(ev) {
    let params=getParams(),
        eventDateInput=$('#EventDate'),
        dateTime,now=new Date();
    $('#eventParams').val(params);
    if (eventDateInput.val()===''){
        let month=now.getMonth()<9?`0${(now.getMonth())+1}`:(now.getMonth())+1;
        dateTime=`${now.getFullYear()}-${month}-${noew.getDate()} ${now.getHours()}:${now.getMinutes()}`
    } else{
        dateTime=`${eventDateInput.val()} ${$('#EventTime').val()}`;
    }
    
    $('#eventDateTime').val(dateTime);
}

function getParams() {
    let params = $('.params'), res = ``;
    params.each((i, el) => {
        let elem = $(el);
        if ((elem.children('input')).val() !== '') {
            res += `${(elem.children('label')).text()}${(elem.children('input')).val()};`
        }
    });
    return res;
}



function getUserProfile(id,ev) {
    let el=$(ev.currentTarget);
    if (!el.hasClass('opened-profile')) {
        $.post("/Admin/GetUserProfile", {id: id},(data)=>loadProfileData(data,el));
    }else{
        el.removeClass('opened-profile')
            .text('Показать профиль пользователя');
        $('.profile-area').hide();
    }
}
function loadProfileData(data,el) {
    let html,
        profileDataArea=$('#profile-data'),
        currentButton=el,
        openedButton=$('.profile-button.opened-profile'),
        profileArea=$('.profile-area');
    
    if (data.successStatus){
        html = `
    <div>
        <span>Имя:</span>
        <span>${(data.FirstName===null?"---":data.FirstName)}</span>
    </div>
    <div>
        <span>Фамилия:</span>
        <span>${(data.SecondName===null?"---":data.SecondName)}</span>
    </div>
    <div>
        <span>Номер мобильного телефона:</span>
        <span>${(data.PhoneNumber===null?"---":data.PhoneNumber)}</span>
    </div>
    <div>
        <span>Возраст:</span>
        <span>${(data.Age===0?"---":data.Age)}</span>
    </div>
    <div>
        <span>Пол:</span>
        <span>${(data.Sec===null?"---":data.Sec)}</span>
    </div>
    <div>
        <span>Место работы:</span>
        <span>${(data.WorkPlace===null?"---":data.WorkPlace)}</span>
    </div>
    <div>
        <span>Место учебы:</span>
        <span>${(data.EducPlace===null?"---":data.EducPlace)}</span>
    </div>
    <div>
        <span>О себе:</span>
        <span>${(data.About===null?"---":data.About)}</span>
    </div>`;
    }else{
        html = "<div>К сожалению не удалось получить профиль пользователя</div>>";
    }
    openedButton
        .text("Профиль пользователя")
        .removeClass('opened-profile');
    
    currentButton
        .text("Скрыть профиль пользователя")
        .addClass('opened-profile');
    profileDataArea.html(html);
    if (profileArea.is(':hidden')){
        profileArea.show()
    } 
}
function  cancelFollowing(userId,eventId,event){
    let el=$(event.currentTarget),
        userBox=el.closest('div.followed-event-user'),
        followersCount=$('#followers-count');
    $.post("/Admin/CancelEventUserFollowing",{userId:userId,eventId:eventId},(data)=>{
        if (data.successStatus){
            userBox.remove();
            followersCount.text(parseInt(followersCount.text())-1);
        }else{
            console.log("Не вышло");
        } 
    });
}


function followOrCancelEvent(id,event) {
    let el=$(event.currentTarget),
        url=el.hasClass('follow-button')?"FollowEvent":"CancelFollowingEvent",
        followersCount= $(`#followers-count-${id}`);
    
    $.post(`/User/${url}`,{id:id}, (data)=>{
        if (data.successStatus) {
            if (data.action === "cancel") {
                el.addClass("follow-button");
                el.text("Подписаться на мероприятие");
                followersCount.text(parseInt(followersCount.text())-1);
            }else{
                el.removeClass("follow-button");
                el.text("Отменить подписку");
                followersCount.text(parseInt(followersCount.text())+1);
            }
        }else {
            console.log(data);
        }
    })
}
function removeEventFromProfile(id, ev) {
    let eventBlock=$(ev.currentTarget).closest('.event'),
        count=$('#profile-folowed-event-count');
    
    $.post("/User/CancelFollowingEvent",{id:id},(data)=>{
        if (data.successStatus) {
            eventBlock.remove();
            count.text(parseInt(count.text())-1);
        }else{
            console.log(data);
        }
    })
}

function deleteEvent(id, ev) {
    let el=$(ev.currentTarget),
        eventBox=el.closest('.event-on-index');
    $.post("/Admin/DeleteEventAjax",{id:id},(data)=>{
        if (data.sucssStatus) {
            eventBox.remove();
        }
    })
}