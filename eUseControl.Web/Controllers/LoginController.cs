using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    {
          private readonly ISession _session;
          public LoginController()
          {
               var bl = new BussinessLogic();
               _session = bl.GetSessionBL();
          }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
     [HttpPost]
     [ValidateAntiForgeryToken]
     public ActionResult Index(UserLogin login)
     {
          if (ModelState.IsValid)
          {
               ULoginData data = new ULoginData
               {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = RequestNotification.UserHostAddress,
                    LoginDateTime = DateTime.Now
               };

               var userLogin = _session.UserLogin(data);
               if(userLogin.Status)
               {
                    //ADD COOKiE
                    return RedirectToAction("Index", "Home");
               }
               else
               {
                    ModelState.AddModeError("", userLogin.StatusMsg);
                    return View();
               }

          }
     }

}