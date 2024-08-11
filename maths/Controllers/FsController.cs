using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace maths.Controllers
{
    public class FsController : Controller
    {
        // GET: Fs
        public ActionResult Fibonaaci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fibonacci(FormCollection form)
        {
            int n = Convert.ToInt32(form["t1"]);
            try
            {
                List<int> numbers = new List<int>();
                int num1 = 0, num2 = 1;

                for (int i = 0; i < n; i++)
                {
                    numbers.Add(num1);
                    int num3 = num2 + num1;
                    num1 = num2;
                    num2 = num3;
                    ViewBag.Numbers = numbers;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Numbers = "An error occurred: " + ex.ToString();
            }
            return View("Fibonaaci");
        }
    }
}