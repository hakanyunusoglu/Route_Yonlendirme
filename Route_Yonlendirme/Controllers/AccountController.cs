using Route_Yonlendirme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route_Yonlendirme.Controllers
{
    public class AccountController : Controller
    {
        kullaniciEntities db = new kullaniciEntities();
        UserDetailModel udm = new UserDetailModel();
        // GET: Account
        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(userTablo usr)
        {
            db.userTablo.Add(usr);
            db.SaveChanges();
            return RedirectToAction("UserDetail", new { username = usr.firstname});
        }
        [Route("u/{username}")]
        public ActionResult UserDetail(string username)
        {
            if(User== null)
            {
                return new HttpNotFoundResult();
            }
            else { 
            var model = db.userTablo.FirstOrDefault(x => x.firstname == username);          
            return View(model);
            }
        }
    }
}