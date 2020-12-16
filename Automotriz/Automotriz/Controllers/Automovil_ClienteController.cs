using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automotriz.Models;
using Automotriz.Models.Modelos_Usuario;

namespace Automotriz.Controllers
{
    public class Automovil_ClienteController : Controller
    {
        private readonly ConcesionariaEntities db = new ConcesionariaEntities();
        // GET: Automovil


        public ActionResult Index(int Id)
        {
            var c = (from c2 in db.Clientes
                     where c2.IdCliente == Id
                     select new
                     {
                         c2.Numero,
                         c2.Nombre
                     }).FirstOrDefault();
            ViewBag.Folio = c.Numero;
            ViewBag.NombreCliente = c.Nombre;

            //Guardar en la memoria
            Response.Cookies["AutoCliente"]["IdCliente"] = Id.ToString();
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

            return PartialView("_Grid_AutoCliente", auto);
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
