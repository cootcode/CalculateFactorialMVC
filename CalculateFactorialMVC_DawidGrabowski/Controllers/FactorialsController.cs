using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculateFactorialMVC_DawidGrabowski.Models;

namespace CalculateFactorialMVC_DawidGrabowski.Controllers
{
    public class FactorialsController : Controller
    {

        //sends the empty form to the browser
        [HttpGet]
        public ActionResult CalculateFactorial()
        {
            return View();
        }
        //this action is called when the user clicks the submit button
        //the completed form is sent to the back end
        [HttpPost]
        public ActionResult CalculateFactorial(FactorialCalc model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateFactorial();
            }
            return View(model); //return the model with all values calculated
        }
    }
}