using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projtrial.Models
{
    public class Employeesdetail
    {
        [Required(ErrorMessage = "please select the title required")]
        [Column(TypeName = "VARCHAR(3)")]
        [StringLength(3)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Display(Name = "First Name")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string First_name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "last Name")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string Last_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "please select the gender")]
        [Display(Name = "Gender")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(7)]
        public string Gender { get; set; }
        [Required]
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "enter the valid password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string Password { get; set; } = string.Empty;

        //[RegularExpression(@"^\w+(@[a-z]\.com)|\w$")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Id")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        [RegularExpression(@"[a-zA-Z0-9_\-\.]+[@][a-z]+[\.][a-z]{2,3}$", ErrorMessage = "Email is not valid")]
        public string Email_ID { get; set; } = string.Empty;
        [Display(Name = "Mobile number")]
        [Column(TypeName = "VARCHAR")]

        [RegularExpression(@"^[0-9]{10}$")]
        public int Mobile_Number { get; set; }
        [Required(ErrorMessage = "address is required")]
        [Display(Name = "Address")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(35)]
        public string Address { get; set; } = string.Empty;
        [Required(ErrorMessage = "Country field is required")]
        [Display(Name = "Country")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Country { get; set; } = string.Empty;
        [Required(ErrorMessage = "Salary field is required")]
        [Range(1000, 10000000)]
        [Display(Name = "Salary")]
        [Column(TypeName = "VARCHAR")]
        public int Salary { get; set; }
        [Required]
        [Display(Name = "Designation")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string Designation { get; set; }
        [Display(Name = "Upload image")]
        public string upload_image { get; set; }





    }
}
