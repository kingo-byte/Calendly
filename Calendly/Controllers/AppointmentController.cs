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
            var appointements = BusinessDao.getAppointements();

            return View();
        }
    }
}