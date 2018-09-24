namespace EventPlaining.Models
{
    public class ConfigModel
    {
        public SmptSetings smptSetings { get; set; }
       
        
        public class SmptSetings
        {
            public string host { get; set; }
            public int port{ get; set; }
            public bool ssl{ get; set; }
            public string authenticateLogin { get; set; }
            public string authenticatePasword { get; set; }
        }
    }
}