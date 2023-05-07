using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calendly.Models
{
    public class User
    {
        public int userId { get; set; } 
        public string userName { get; set; }    
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Appointement> appointements { get; set; }
    }
}