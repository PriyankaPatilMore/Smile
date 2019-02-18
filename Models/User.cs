namespace Smile.API.Models
{
    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string password {get; set;}
        public Role Role {get; set;}
    }
}