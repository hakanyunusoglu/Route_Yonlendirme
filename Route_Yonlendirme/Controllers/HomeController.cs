using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route_Yonlendirme.Controllers
{
    [RoutePrefix("Main")]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }
        [Route("ContactUs")]
        public ActionResult Contact()
        {
            return View();
        }
        [Route("~/Demo/{number=1}/{id?}")]
        public ActionResult Demo(int number, int? id)
        {
            return Content(string.Format("Number={0} <br/> ID={1}", number, id.HasValue ? id.ToString() : "null")); ;
        }
    }
}