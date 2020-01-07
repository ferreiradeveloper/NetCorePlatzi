using System;
using Microsoft.AspNetCore.Mvc;
using NetCorePlatzi.Models;

namespace NetCorePlatzi.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index(){
            var asignatura = new Asignatura(){
                UniqueId = System.Guid.NewGuid().ToString(),
                Nombre = "Programación"   
            };

            ViewBag.CosaDinamica = "El Brujo";
            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }
    }
}