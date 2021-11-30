using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace Practica4.Controllers
{
    public class PrestamosController : Controller
    {
        private BibliotecaEntities _contexto;

        public BibliotecaEntities Contexto
        {
            set
            {
                _contexto = value;
            }
            get
            {
                if (_contexto == null)
                    _contexto = new BibliotecaEntities();
                return _contexto;
            }
        }
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Create(Prestamos nuevoPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Prestamos.Add(nuevoPrestamo);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoPrestamo);
            }
            catch
            {
                return View();
            }
        }


        //GET
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Prestamos PrestamosEditar = Contexto.Prestamos.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (PrestamosEditar == null)
                return HttpNotFound();

            return View(PrestamosEditar);
        }

        [HttpPost]
        public ActionResult Edit(Prestamos PrestamosEditar)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(PrestamosEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamosEditar);
            }
            catch (Exception e)
            {
                throw e;
                //return View();
            }
        }

        //GET
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Prestamos PrestamosEliminar = Contexto.Prestamos.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (PrestamosEliminar == null)
                return HttpNotFound();

            return View(PrestamosEliminar);
        }

        //POST
        [HttpPost]
        public ActionResult Delete(int? id, Prestamos Prestamos1)
        {
            try
            {
                Prestamos CategoriaEliminar = new Prestamos();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    //busca categoria a eliminar
                    CategoriaEliminar = Contexto.Prestamos.Find(id);

                    //Si no encuentra la categoria
                    if (CategoriaEliminar == null)
                        return HttpNotFound();

                    //Elimina la categoria
                    Contexto.Prestamos.Remove(CategoriaEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}