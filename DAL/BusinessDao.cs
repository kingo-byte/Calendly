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

        public static void EditUserPersonalInformation(User user)
        {
            db.ExecuteNonQuery(
            "UpdateUserPersonalInformation",
                new 
                {
                  UserId = user.userId,
                  UserName = user.userName, 
                  FirstName = user.firstName,
                  LastName = user.lastName, 
                }
            );
        }

        public static void EditUserLegalInformation(User user)
        {
            db.ExecuteNonQuery(
                "UpdateUserLegalInformation",
                    new { 
                        UserId = user.userId,
                        PhoneNumber = user.phoneNumber,
                        Email = user.email,
                        Occupation = user.occupation
                    }
                );
        }
    }
}
