using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult ValidateUser(string emailAddress, string password)
        {

            using (var context = new SampleEntities1())
            {
                var userObj = context.Users.Where(x => x.EmailAddress == emailAddress && x.Password == password).FirstOrDefault();
                if (userObj == null)
                {
                    userObj = new User();
                }
                return Json(userObj);

                //else
                //{
                //    ViewBag.DisplayUserModel = userObj;
                //}

                //if (userObj != null)
                //{
                //    return  View("../PersonDetails/PersonDetails"); //RedirectToAction("PersonDetails", "PersonDetails");
                //}
                //else
                //{
                //    return Json(new { Content = "Invalid user details" }); 
                //}


            }
           
        }
    }
}