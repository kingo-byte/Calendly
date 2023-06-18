using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Models;
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
            UserViewModel viewModel = new UserViewModel();  

            var user = BusinessDao.getUser(userId);

            var appointements = BusinessDao.getAppointements(userId);

            viewModel.User = user;
            viewModel.Appointements = appointements;

            if (user != null && appointements != null)
            {

                viewModel.Appointements = appointements;

                var parsedData = new
                {
                    userName = viewModel.User.UserName,
                    userId = viewModel.User.UserId,

                    appointements = viewModel.Appointements.Select(c => new
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