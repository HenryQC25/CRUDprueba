using CRUDprueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDprueba.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult persona()
        {
            return View();
        }

        public ActionResult personaPerfil()
        {
            return View();
        }

        [HttpGet]
        public JsonResult obtenerPersonas()
        {
            List<persona>  ltspersonas= new List<persona>();
            persona p = new persona();
            ltspersonas= p.obtenerPersonas();

            return Json(ltspersonas,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult insertarPersona(persona p)
        {
            persona persona = new persona();
            int respuesta = persona.insertarPersona(p);
            return Json(respuesta, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult obtenerPersona(int cui)
        {
            persona persona1 = new persona();
       
            persona1 = persona1.obtenerPersona(cui);

            return Json(persona1, JsonRequestBehavior.AllowGet);
        }

    }
}