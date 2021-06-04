using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sorokina_lab1.Models;
using Sorokina_lab1.Services;

namespace _931803_Sorokina_lab1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public ActionResult Using_model_calc()
        {
            Random rnd = new Random();

            var viewModel = new Calc();

            viewModel.title = "PassUsingModel";

            viewModel.a = rnd.Next(0, 10);
            viewModel.b = rnd.Next(0, 10);

            viewModel.add = viewModel.a + viewModel.b;
            viewModel.sub = viewModel.a - viewModel.b;
            viewModel.mult = viewModel.a * viewModel.b;
            if (viewModel.b != 0)
                viewModel.div = viewModel.a / viewModel.b;


            return View(viewModel);
        }
        public ActionResult ViewData_calc()
        {
            Random rnd = new Random();


            int a = rnd.Next(0, 10);
            int b = rnd.Next(0, 10);
            int add = a + b;
            int sub = a - b;
            int mult = a * b;
            if (b != 0)
            {
                int div = a / b;
                ViewData["div"] = div;
            }
            else { ViewData["div"] = "Impossible"; }

            ViewData["a"] = a;
            ViewData["b"] = b;
            ViewData["add"] = add;
            ViewData["sub"] = sub;
            ViewData["mult"] = mult;

            return View();
        }
        public ActionResult ViewBag_calc()
        {
            Random rnd = new Random();

            ViewBag.a = rnd.Next(0, 10);
            ViewBag.b = rnd.Next(0, 10);

            ViewBag.add = ViewBag.a + ViewBag.b;
            ViewBag.sub = ViewBag.a - ViewBag.b;
            ViewBag.mult = ViewBag.a * ViewBag.b;
            if (ViewBag.b != 0) { ViewBag.div = ViewBag.a / ViewBag.b; }
            else { ViewBag.div = "Impossible!"; }

            return View();
        }
        public ActionResult ServiceInjection_calc()
        {
            return View();
        }
    }
}
