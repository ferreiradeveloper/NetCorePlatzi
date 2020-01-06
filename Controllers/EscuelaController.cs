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

            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString(); 
            escuela.Nombre = "Platzi School";
            escuela.Pais = "España";
            escuela.Ciudad = "Madrid";
            escuela.TipoEscuela =TiposEscuela.Secundaria; 
            escuela.Dirección = "Carrer de Claramunt 34";   

            ViewBag.CosaDinamica = "El Monje";
            return View(escuela);
        }
    }
}