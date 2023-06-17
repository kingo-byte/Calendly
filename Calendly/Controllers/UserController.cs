using Common.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Calendly.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            List<User> users = BusinessDao.getUsers();

            if (users != null)
            {
                return View(users);
            }

            return View();
        }

        public ActionResult EditCustomer(int id) { 
        
            User user = BusinessDao.getUser(id);

            if (user != null) {

                return View(user);
            }

            return RedirectToAction ("Index");  
        }
    }
}