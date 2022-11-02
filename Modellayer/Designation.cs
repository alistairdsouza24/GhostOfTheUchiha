using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeLlayer
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Designation is  Required")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Add_designation { get; set; }

    }
}
