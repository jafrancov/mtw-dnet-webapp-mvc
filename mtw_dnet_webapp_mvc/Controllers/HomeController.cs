using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mtw_dnet_webapp_mvc.Models;

namespace mtw_dnet_webapp_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string TestPage()
        {
            return "Saludos!";
        }

        public IActionResult TestPage2()
        {
            ViewData["mensaje"] = "Mensaje de contexto";
            return View();
        }

        public IActionResult TestPage3()
        {
            Persona alejandro = new Persona
            {
                Nombre = "Alejandro Franco",
                Edad = 34
            };
            return View(alejandro);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
