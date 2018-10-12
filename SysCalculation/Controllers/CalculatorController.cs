using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysCalculation.Models;

namespace SysCalculation.Controllers
{


//Create a simple MVC application that takes 2 numbers for input and returns the sum of the two numbers after the user clicks a button that says “Add”.  The platform should be.NET 4.7.2 or.NET Core 2.1 Either one is fine.

//You can create a repository on Git (with your name) and upload the project there.If you compress it, please use ZIP format.
    public class CalculatorController : Controller
    {
        // GET: Calculator
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Result(ModelAddition modelBinders)
        {
            ViewBag.result = modelBinders.firstValue + modelBinders.secondValue;
          
            return View("~/Views/Calculator/Index.cshtml");
            //return JsonResult();
        }


    }
}