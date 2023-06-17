using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BusinessDao
    {
        private static DapperAccess db = new DapperAccess();

        public static List<Appointement> getAppointements(int id) {

            return db.Execute<Appointement>("GetAppointements", new { userId = id }).ToList();
        }

        public static User getUser(int id) {

            return db.Execute<User>("GetUser", new { userId = id }).FirstOrDefault();
        }

        public static List<User> getUsers()
        {
            return db.Execute<User>("GetUsers", null);
        }
    }
}
