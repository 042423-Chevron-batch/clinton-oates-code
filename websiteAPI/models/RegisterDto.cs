using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rps_Models
{
    public class RegisterDto
    {
        public RegisterDto() { }

        public RegisterDto(string fname, string lname)
        {
            //this.age = age;
            this.FirstName = fname;
            this.LastName = lname;
        }

        // this constructor will take the data from the Chinook Db (for demo purposes)
        public RegisterDto(string username, string password, string fname, )
        {
            this.UserName = username;
            this.Password = password;
            this.FirstName = fname;
        }


        public RegisterDto(Guid id, string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            //this.CustomerId = id;
            this.FirstName = fn;
            
            this.LastOrderDate = dt;
            this.Remarks = remarks;
            this.UserName = username;
            this.Password = pw;
        }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The {0} length must be between {2} and {1}.")]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The {0} length must be between {2} and {1}.")]
        public string FirstName { get; set; }



        public string Remarks { get; set; }

        public DateTime LastOrderDate { get; set; }

        // [RegularExpression(@"^[A-Z0-9+_.-]+@[A-Z0-9.-]+$", ErrorMessage = "Got an error")]// The part before the @ restricts to characters commonly used in emails. The part after the @ restricts to characters allowed in domain names.
        // public string Email { get; set; }
    }
}