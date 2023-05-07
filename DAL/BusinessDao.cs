using DAL.Models;
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

        public static List<Appointement> getAppointements() {

            return db.Execute<Appointement>("GetAppointements", null).ToList();
        }

        public static void insertAppointement() {

            db.ExecuteNonQuery("InsertAppointement", null);
        }
    }
}
