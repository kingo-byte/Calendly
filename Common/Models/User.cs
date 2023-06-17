using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string personalId { get; set; }
        public string occupation { get; set; }
        public bool? isMarried { get; set; }
        public int NbOfChildren { get; set; }
        public string WifeName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public float? Salary { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<Appointement> appointements { get; set; }
    }
}
