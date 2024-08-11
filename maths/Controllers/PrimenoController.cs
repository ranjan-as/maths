using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maths.Controllers
{
    public class PrimenoController : Controller
    {
        // GET: Primeno
        public ActionResult Prime()
        {
            return View();
        }
        
            [HttpPost]
            public ActionResult Prime(FormCollection form)
            {
                try
                {
                    int number = Convert.ToInt32(form["Number"]);

                    if (number <= 1)
                    {
                        ViewBag.hmm = "Enter a natural number greater than 1.";
                    }
                    else
                    {
                        bool isPrime = true;
                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        ViewBag.hmm = isPrime ? "This is a prime number." : "This is not a prime number.";
                    }
                }
                catch
                {
                    ViewBag.hmm = "Please enter a valid number.";
                }


                return View();
        }

    }
}

