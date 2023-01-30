using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmiliaMorejón_EjercicioDF.Models;
//using EmiliaMorejón_EjercicioDF.Mediators;

namespace EmiliaMorejón_EjercicioDF.Controllers
{
    public class ArtistasController : Controller
    {
        private IArtistaMediator _artistaMediator;

        public ArtistasController(IArtistaMediator artistaMediator)
        {
            _artistaMediator = artistaMediator;
        }

        // GET: Artistas
        public ActionResult Index()
        {
            return View(_artistaMediator.ObtenerTodos());
        }

        // GET: Artistas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artista artista = _artistaMediator.ObtenerPorId(id.Value);
            if (artista == null)
            {
                return HttpNotFound();
            }
            return View(artista);
        }

        // GET: Artistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artistas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtistaID,NombrePilaArtista,NombreArtistico,FechaNacimiento")] Artista artista)
        {
            if (ModelState.IsValid)
            {
                _artistaMediator.Crear(artista);
                return RedirectToAction("Index");
            }

            return View(artista);
        }

        // GET: Artistas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artista artista = _artistaMediator.ObtenerPorId(id.Value);
            if (artista == null)
            {
                return HttpNotFound();
            }
            return View(artista);
        }

        // POST: Artistas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtistaID,NombrePilaArtista,NombreArtistico,Fecha
}

    internal interface IArtistaMediator
    {
    }
}