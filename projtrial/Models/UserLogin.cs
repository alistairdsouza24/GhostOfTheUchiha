using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projtrial.Models
{
    public class Userlogin
    {
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string? Password { get; set; }
    }
}
