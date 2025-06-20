using System.ComponentModel.DataAnnotations;

namespace Bio.Model.Entity
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        public string Role { get; set; }

        public string UserName { get; set; }
        //hhh
        public string Password { get; set; }
    }
}
