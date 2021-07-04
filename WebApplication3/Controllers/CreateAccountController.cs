using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class CreateAccountController : Controller
    {
        // GET: CreateAccount
        public ActionResult CreateAccount()
        {
            return View();
        }

        public ActionResult SaveUser(User userObject) // (string firstName, string password, string emailAddress, long phonenumber)
        {

            using (var context = new SampleEntities1())
            {
                //var userObject = new User()
                //{
                //    FirstName = firstName,
                //    Password = password,
                //    EmailAddress = emailAddress,
                //    PhoneNumber = phonenumber

                //};
                context.Users.Add(userObject);

                context.SaveChanges();
            }
            return Json(new { Content = "Success" }); ;
        }
    }
}