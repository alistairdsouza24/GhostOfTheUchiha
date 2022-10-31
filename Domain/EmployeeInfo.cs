using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "please select the title required")]
        public string Title { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required(ErrorMessage = "please select the gender")]
        public string Gender { get; set; }
        [Required]
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "enter the valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [RegularExpression(@"^[\w.%+\-]+@[\w.\-]+\.[A-Za-z]{2,3}$/")]
        [DataType(DataType.EmailAddress)]
        public string Email_ID { get; set; }

        [RegularExpression(@"^[0-9]{10}$")]
        public int Mobile_Number { get; set; }
        [Required(ErrorMessage = "address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Country field is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Salary field is required")]
        [Range(1000, 10000000)]
        public int Salary { get; set; }
        [Required]
        public string Designation { get; set; }

        public string upload_image { get; set; }



    }
}
