using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace maths.Filters
{
    public class MyFilter: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Console.Write("ABC");
            base.OnActionExecuted(filterContext);
            Test("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            Test("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            Test("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            Test("OnResultExecuting", filterContext.RouteData);
        }

        private void Test(string evt, RouteData routdata)
        {
            Console.WriteLine("{0} Hello",evt);
            Console.WriteLine("{0}",routdata.Values);
        }
    }
}