using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMVCVoorbeeld.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = {"Tomaat", "Komkommer", "Ijsbergsla", "Champignon" };

        public ViewResult Index()
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeiemiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }

            return View();
        }
    }
}