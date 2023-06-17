using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace Calendly.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index(int? userId)
        {
            return View();
        }

        // GET: User
        public JsonResult UserAppointments(int userId)
        {
            var user = BusinessDao.getUser(userId);

            var appointements = BusinessDao.getAppointements(userId);

            if (user != null && appointements != null)
            {

                user.appointements = appointements;

                var parsedData = new
                {
                    userName = user.userName,
                    userId = user.userId,

                    appointements = user.appointements.Select(c => new
                    {
                        id = c.appId,
                        title = c.title,
                        start = c.start.ToString("yyyy-MM-dd hh:mm:ss"),
                        end = c.end.ToString("yyyy-MM-dd hh:mm:ss"),
                    }).ToList()
                };

                return Json(parsedData);
            }

            return null;
        }
    }
}