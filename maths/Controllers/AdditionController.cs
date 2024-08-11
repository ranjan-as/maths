using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maths.Controllers
{
    public class AdditionController : Controller
    {
        // GET: Addition
        public ActionResult Addition()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addition(FormCollection form)
        {
            string one, two;
            try
            {
                one = form["txtOne"];
                two = form["txtTwo"];
                int a, b, r;
                a = Convert.ToInt32(one);
                b = Convert.ToInt32(two);
                r = a + b;
                ViewBag.One = r;
            }
            catch (FormatException ex)
            {
                ViewBag.One = ex.ToString();//"wrong input";
            }
            return View();
        }
    }
}