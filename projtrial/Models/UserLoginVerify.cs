using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace projtrial.Models
{
    public class Userloginverify
    {
        [Key]
        public string username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
       // public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }
}
