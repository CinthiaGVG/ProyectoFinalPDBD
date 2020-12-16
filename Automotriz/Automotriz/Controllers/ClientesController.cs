using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automotriz.Models;
using Automotriz.Models.Modelos_Usuario;


namespace Automotriz.Controllers
{
    public class ClientesController : Controller
    {
        //Objeto de la clase para la conexion a la base de datos
        private readonly ConcesionariaEntities db = new ConcesionariaEntities();
        // GET: Clientes
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Clientes/Details/5
        public ActionResult Nuevo_Cliente()

        {
            //Consulta a la base datos 
            var muni = (from m in db.Municipios
                        select new
                        {
                            Id = m.IdMunicipio,
                            Text = m.Nombre
                        }).ToList();

            SelectList muniList = new SelectList(muni, "Id", "Text");
            ViewBag.IdMunicipio = muniList;
            return PartialView("_Nuevo_Cliente");
        }
        [ValidateAntiForgeryToken]
        [HttpPost]

        //Recibe datos en un modelo
        public ActionResult Nuevo_Cliente(Cliente_Modelo cli)
        {
            if (!ModelState.IsValid)
            {
                //Consulta a la base datos 
                var muni = (from m in db.Municipios
                            select new
                            {
                                Id = m.IdMunicipio,
                                Text = m.Nombre
                            }).ToList();

                SelectList muniList = new SelectList(muni, "Id", "Text");
                ViewBag.IdMunicipio = muniList;
                return PartialView("_Nuevo_Cliente", cli);
            }
            //Consulta a la base de datos viendo el ultimo que se ingreso 
            cli.Numero = (from c in db.Clientes
                          orderby c.Numero descending
                          select c.Numero
                          //Cuando haces una consulta y el resultado no sera una lista "FirsOrDefault"
                        ).Take(1).DefaultIfEmpty(0).FirstOrDefault()+1;

            //No puedes crear un objeto con un modelo manualmente ( esto es de la base de datos)

            Cliente ins = new Cliente() {
                Numero =cli.Numero,
                Nombre =cli.Nombre,
                Direccion =cli.Direccion,
                FechaNac =cli.FechaNac,
                Sexo =cli.Sexo,
                TelCasa =cli.TelCasa,
                TelCel =cli.TelCel,
                Correo =cli.Correo,
                RFC =cli.RFC,
                IdMunicipio = cli.IdMunicipio,
                //IdEstado_Cliente =cli.IdEstado_Cliente,

            };
            db.Clientes.Add(ins);
            db.SaveChanges();


            return Json(new { flag = 1, message = "El registro ha sido exitosamente guardado" },  JsonRequestBehavior.AllowGet);
        }
        
        
        public ActionResult Actualizar_Cliente(int Id)
        {
            //Consulta para traer un registro y traer los valores
            Cliente_Modelo M = (from c in db.Clientes
                         where c.IdCliente == Id
                         select new Cliente_Modelo { IdCliente=c.IdCliente,
                         Nombre=c.Nombre,
                         Numero=c.Numero,
                         Correo=c.Correo,
                         Direccion=c.Direccion,
                         Sexo=c.Sexo,
                         TelCasa=c.TelCasa,
                         TelCel=c.TelCel,
                         RFC=c.RFC,
                         FechaNac=c.FechaNac,
                         IdMunicipio=c.IdMunicipio,
                         }).FirstOrDefault();

            //Regrese los valores y los acomode
            //Consulta a la base datos 
            var muni = (from m in db.Municipios
                        select new
                        {
                            Id = m.IdMunicipio,
                            Text = m.Nombre
                        }).ToList();

            //SelectList muniList = new SelectList(muni, "Id", "Text",M.IdMunicipio);
            ViewBag.Municipio = muni;
            return PartialView("_Actualizar_Cliente",M);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]

        //Recibe datos en un modelo
        public ActionResult Actualizar_Cliente(Cliente_Modelo cli)
        {
            if (!ModelState.IsValid)
            {
                //Consulta a la base datos 
                var muni = (from m in db.Municipios
                            select new
                            {
                                Id = m.IdMunicipio,
                                Text = m.Nombre
                            }).ToList();

                SelectList muniList = new SelectList(muni, "Id", "Text");
                ViewBag.IdMunicipio = muniList;
                return PartialView("_Actualizar_Cliente", cli);
            }

            //Modelo desde la conexion a la base datos 
            //Para saber si ele registro realmente existe y cambiarle los valores
            Cliente M = (from c in db.Clientes
                         where c.IdCliente == cli.IdCliente
                         select c).FirstOrDefault();


            //No puedes crear un objeto con un modelo manualmente ( esto es de la base de datos)
            //Tienes los datos que el cliente te dio y ahora ya los vas a modificar


            M.Nombre = cli.Nombre;
            M.Direccion = cli.Direccion;
            M.FechaNac = cli.FechaNac;
            M.Sexo = cli.Sexo;
            M.TelCasa = cli.TelCasa;
            M.TelCel = cli.TelCel;
            M.Correo = cli.Correo;
            M.RFC = cli.RFC;
            M.IdMunicipio = cli.IdMunicipio;
                //IdEstado_Cliente =cli.IdEstado_Cliente,

        
            
            db.SaveChanges();


            return Json(new { flag = 1, message = "El registro ha sido exitosamente actualizado" },  JsonRequestBehavior.AllowGet);
        }


        // GET: Clientes/Create

        //Metodo que me devuelve
        public ActionResult Grid_Index()
        {
            //var Variable de cualquier tipo "m" nombre de la variable ..from codigo linq para conexion a la base de datos
            // c consulta en base de datos
            var m = (from c in db.Clientes
                     orderby c.IdCliente descending

                     //creacion del modelo ..valor del modelo y de donde viene
                     select new Grid_cliente_modelo
                     {
                        IdCliente=c.IdCliente,
                        Nombre=c.Nombre,
                        Numero=c.Numero,
                        //AsQueryable es como una lista para grids
                     }).AsQueryable();

            //lo retornas como una Vista parcial
            return PartialView("_Grid_Index", m);
        }

        // POST: Clientes/Create
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

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
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

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
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
