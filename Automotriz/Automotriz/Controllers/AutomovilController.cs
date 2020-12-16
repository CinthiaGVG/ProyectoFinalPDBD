using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automotriz.Models;
using Automotriz.Models.Modelos_Usuario;


namespace Automotriz.Controllers
{
    public class AutomovilController : Controller
    {
        //Parra la conexion a la base de datos 
        private readonly ConcesionariaEntities db = new ConcesionariaEntities();
        // GET: Automovil


        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Automovil/Details/5

        //Retornar los autos que tiene el cliente
        public ActionResult Grid_AutosCliente()
        {
            //Recuperar el id del cliente del cache
            var idcliente = Convert.ToInt32(Request.Cookies["AutoCliente"]["IdCliente"]);

            var auto = (from c in db.Automovils
                     orderby c.IdAutomovil descending

                     //creacion del modelo ..valor del modelo y de donde viene
                     select new Grid_Automovil
                     {
                         IdAutomovil = c.IdAutomovil,
                        
                         Numero = c.Numero,
                         //AsQueryable es como una lista para grids
                     }).AsQueryable();

            return PartialView("_Grid_AutoCliente",auto);
        }


        // GET: Automovil/Create
        public ActionResult Nuevo_Automovil()
        {
            return View();
        }

        // POST: Automovil/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automovil/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Automovil/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automovil/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automovil/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
