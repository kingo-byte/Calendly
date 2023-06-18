using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DAL
{
    public static class BusinessDao
    {
        private static DapperAccess db = new DapperAccess();

        private static EntityFrameWorkAccess context = new EntityFrameWorkAccess();    

        public static List<Appointement> getAppointements(int id) {

            return db.Execute<Appointement>("GetAppointements", new { userId = id }).ToList();
        }

        public static User getUser(int id) {

            return db.Execute<User>("GetUser", new { userId = id }).FirstOrDefault();
        }

        public static List<User> getUsers()
         {
            var x = context.User.ToList();
            
            return db.Execute<User>("GetUsers", null);
        }

        public static void EditUserPersonalInformation(User user)
        {
            db.ExecuteNonQuery(
            "UpdateUserPersonalInformation",
                new 
                {
                  UserId = user.UserId,
                  UserName = user.UserName, 
                  FirstName = user.FirstName,
                  LastName = user.LastName, 
                }
            );
        }

        public static void EditUserLegalInformation(User user)
        {
            db.ExecuteNonQuery(
                "UpdateUserLegalInformation",
                    new { 
                        UserId = user.UserId,
                        PhoneNumber = user.PhoneNumber,
                        Email = user.Email,
                        Occupation = user.Occupation
                    }
                );
        }
    }
}
