using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeLlayer
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Add Designation")]
        public string Add_designation { get; set; }

    }
}
