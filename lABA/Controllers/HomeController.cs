using lABA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lABA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }
        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            switch (model.Operator)
            {
                case "add":
                    model.Result = model.ValueOne + model.ValueTwo;
                    break;

                case "min":
                    model.Result = model.ValueOne - model.ValueTwo;
                    break;

                default:
                    model.Result = model.ValueOne * model.ValueTwo;
                    break;
            }

            return View(model);
        }

    }




}
