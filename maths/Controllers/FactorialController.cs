using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maths.Controllers
{
    public class FactorialController : Controller
    {
        // GET: Factorial        
        public ActionResult Fact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Fact(FormCollection form)
        {
            string st = form["txtNo"];
            double r = 1;
            int n = 0;

            try
            {
                n = Convert.ToInt32(st);
                if (n > 0)
                {
                    if (n == 0 || n == 1)
                    {
                        ViewBag.result= r.ToString();
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            r = r * i;
                        }
                        ViewBag.result = r.ToString();
                    }
                }
                else
                {
                    ViewBag.result = "Negative integer not allowed";
                }
            }
            catch (FormatException ex)
            {
                ViewBag.result = ex.ToString();
            }
            return View();
        }
    }

    }