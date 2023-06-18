using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        
        public string Tab { get; set; }

        public List<Appointement> Appointements { get; set; } = new List<Appointement>();
    }
}
