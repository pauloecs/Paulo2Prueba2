using Paulo2Prueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paulo2Prueba2.Controllers
{
    public class ResumenController : Controller
    {

        private FabricaEntities db = new FabricaEntities();
       
        public ActionResult Index()
        {
            return View(db.Categoria.ToList());
        }
    }
}