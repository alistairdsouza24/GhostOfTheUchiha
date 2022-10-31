using System.ComponentModel.DataAnnotations;

namespace projtrial.Models
{
    public class Userlogin
    {
        [Required(ErrorMessage = "please enter username")]
        public string? username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "password is required")]
        public string? password { get; set; }
    }
}
