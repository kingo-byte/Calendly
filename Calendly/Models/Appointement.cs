using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendly.Models
{
    public class Appointement
    {
        public int appId { get; } 
        public string userId { get; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }   
    }
}