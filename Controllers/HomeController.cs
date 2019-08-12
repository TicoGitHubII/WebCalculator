using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Operation model)
        {
         
                switch (model.Operator)
                {
                    case Operator.Add:
                        model.Result = model.Left + model.Right;
                        break;
                    case Operator.Sub:
                        model.Result = model.Left - model.Right;
                        break;
                    case (Operator.Mul):
                        model.Result = model.Left * model.Right;
                        break;
                    case Operator.Div:
                        if (model.Right != 0)
                        {
                            model.Result = model.Left / model.Right;
                        }
                        break;
                    default:
                    Console.WriteLine("InValid Operatpor");
                        break;
                }

               return View(model);
            }


    }

}
