using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maths.Controllers
{
    public class FncController : Controller
    {
        // GET: Fnc
        public ActionResult Fncs()
        {
            return View();         
        }

            [HttpPost]
            public ActionResult Fncs(FormCollection form)
            {
                int n;
                try
                {
                    n = Convert.ToInt32(form["t1"]);
                }
                catch
                {
                    ViewBag.Numbers = new List<int>(); // Still set an empty list
                    ViewBag.ErrorMessage = "Invalid input. Please enter a valid number.";
                    return View();
                }

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
                    }

                    ViewBag.Numbers = numbers;
                    ViewBag.ErrorMessage = null; // Clear any previous error message
                }
                catch (Exception ex)
                {
                    ViewBag.Numbers = new List<int>(); // Set an empty list in case of error
                    ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
                }

                return View(); // Return the same view that contains the form
            }
        }
    }
