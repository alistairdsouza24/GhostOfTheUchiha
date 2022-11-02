using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projtrial.Models
{
    public class MDesignation
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Designation is  Required")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Add_designation { get; set; }

    }
}
