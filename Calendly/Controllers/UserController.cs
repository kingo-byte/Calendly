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

        public ActionResult EditCustomer(int id, string tab) { 
        
            UserViewModel uvm = new UserViewModel();  

            User user = BusinessDao.getUser(id);

            uvm.User = user;    
            uvm.Tab = tab;  

            if (user != null) {

                return View(uvm);
            }

            return RedirectToAction ("Index");  
        }


        public ActionResult SubmitUserPersonalInformation(User user) { 

            BusinessDao.EditUserPersonalInformation(user);  

            return RedirectToAction("EditCustomer", new {id = user.UserId , tab = "tab2"});   
        }

        public ActionResult SubmitUserLegalInformation(User user)
        {
            BusinessDao.EditUserLegalInformation(user);

            return RedirectToAction("Index");
        }

        public ActionResult Previous(int id, string tab)
        {
            return RedirectToAction("EditCustomer", "User", new { id, tab });
        }
    }
}