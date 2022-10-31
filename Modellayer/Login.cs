using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Login
    {

        [Required(ErrorMessage = "please enter username")]
        public string? username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "password is required")]
        public string? password { get; set; }



    }

}
