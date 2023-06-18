using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    [Table("User")]
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PersonalId { get; set; }
        public string Occupation { get; set; }
        public bool? IsMarried { get; set; }
        public int? NbOfChildren { get; set; }
        public string WifeName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public float? Salary { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
