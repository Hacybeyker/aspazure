using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ConductorController : Controller
    {
        // GET: Conductor

        webventapasajeEntities entidad = new webventapasajeEntities();
        public ActionResult Index()
        {
            var listaConductor = entidad.conductor;
            return View(listaConductor.ToList());
        }
    }
}