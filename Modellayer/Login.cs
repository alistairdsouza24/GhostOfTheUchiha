using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Login
    {

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string? username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string? password { get; set; }



    }

}
