using System.ComponentModel.DataAnnotations;

namespace FunTODOWebSite.Models.Login
{
    public class LoginModel : IApplicationModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
