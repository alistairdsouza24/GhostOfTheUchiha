using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace projtrial.Models
{
    public class Mdesignation
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Add Designation")]
        public string Add_designation { get; set; }

    }
}
