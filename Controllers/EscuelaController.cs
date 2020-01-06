using System;
using Microsoft.AspNetCore.Mvc;
using NetCorePlatzi.Models;

namespace NetCorePlatzi.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();

            escuela.AnioFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString(); 
            escuela.Nombre = "Platzi School";

            ViewBag.CosaDinamica = "El Monje";
            return View(escuela);
        }
    }
}