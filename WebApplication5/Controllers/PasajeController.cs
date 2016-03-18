using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class PasajeController : Controller
    {
        // GET: Pasaje
        webventapasajeEntities entidad = new webventapasajeEntities();
        public ActionResult Index()
        {
            var listapasajes = entidad.pasaje;
            return View(listapasajes.ToList());
        }
    }
}