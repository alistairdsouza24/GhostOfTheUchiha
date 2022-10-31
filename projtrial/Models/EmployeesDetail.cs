using System.ComponentModel.DataAnnotations;

namespace projtrial.Models
{
    public class Employeesdetail
    {
        
            [Required(ErrorMessage = "please select the title required")]
            public string Title { get; set; }
            [Required]
            public string First_name { get; set; }
            [Required]
            public string Last_name { get; set; }
            [Required(ErrorMessage = "please select the gender")]
            public string Gender { get; set; }
            [Required]
            [Key]
            public string UserName { get; set; }
            [Required]
            public string Password { get; set; }

           
            [DataType(DataType.EmailAddress)]
            public string Email_ID { get; set; }

            [RegularExpression(@"^[0-9]{10}|\w$")]
            public int Mobile_Number { get; set; }
            [Required(ErrorMessage = "address is required")]
            public string Address { get; set; }
            [Required(ErrorMessage = "Country field is required")]
            public string Country { get; set; }
            [Required(ErrorMessage = "Salary field is required")]
            [Range(1000, 10000000)]
            public string Salary { get; set; }
            [Required]
            public string Designation { get; set; }

            public string upload_image { get; set; }



        
    }
}
