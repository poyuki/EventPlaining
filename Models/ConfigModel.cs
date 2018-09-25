using System;

namespace EventPlaining.Models
{
    public class ConfigModel
    {
        public SmptSetings smptSetings { get; set; }
        public DbSetings dbSetings { get; set; }
        
        public class SmptSetings
        {
            public string host { get; set; }
            public int port{ get; set; }
            public bool ssl{ get; set; }
            public string authenticateLogin { get; set; }
            public string authenticatePasword { get; set; }
        }
        public class DbSetings
        {
            public string server{ get; set; }
            public string database { get; set; }
            public string user { get; set; }
            public string password { get; set; }
            public string version { get; set; }
            public AppAdmin appAdmin { get; set; }
            

            public int getMajorVersion()
            {
                int res = Int32.Parse(this.version.Split('.')[0]);
                return res;
            }
            public int getMinorVersion()
            {
                int res = Int32.Parse(this.version.Split('.')[1]);
                return res;
            }
            public int getPatchVersion()
            {
                int res = Int32.Parse(this.version.Split('.')[2]);
                return res;
            }

            public class AppAdmin
            {
                public string login { get; set; }
                public string password { get; set; }
            }
        }
    }
}