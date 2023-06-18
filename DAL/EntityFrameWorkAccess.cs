using Common.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DAL
{
    public class EntityFrameWorkAccess : DbContext
    {
        public EntityFrameWorkAccess() : base(ConfigurationManager.ConnectionStrings["EFCONN_STRING"].ConnectionString)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
