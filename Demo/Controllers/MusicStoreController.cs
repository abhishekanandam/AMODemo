using Demo.Models;
using Demo.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class MusicStoreController : Controller
    {
        MusicStoreDataContext dbContext = new MusicStoreDataContext();

        ArtistRepository repository = new ArtistRepository();

        // GET: MusicStore
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Details(int id)
        {
            Artist artist = repository.Get(id);
            if (artist == null)
                return HttpNotFound();
            else
                return View(artist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid)
                return View(artist);

            repository.Add(artist);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(AlbumEditViewModel albumEditViewModel)
        //{
        //    var album = new Album()
        //    {
        //        AlbumArtUrl = albumEditViewModel.AlbumArtUrl,
        //        AlbumId = albumEditViewModel.AlbumId,
        //        ArtistID = albumEditViewModel.ArtistId,
        //        GenreId = albumEditViewModel.GenreId,
        //        Price = 9.99m,
        //        Title = albumEditViewModel.Title
        //    };
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.Entry(album).State = System.Data.Entity.EntityState.Modified;
        //        try
        //        {
        //            dbContext.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        catch(DbEntityValidationException ex)
        //        {
        //            foreach(var result in ex.EntityValidationErrors)
        //            {
        //                foreach(var error in result.ValidationErrors)
        //                {
        //                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
        //                }
        //            }
        //            return View(album);
        //        }
        //    }
        //    return View(album);
        //}

        public ActionResult Edit(int id)
        {
            var artist = repository.Get(id);
            if (artist == null)
                return HttpNotFound();
            else
                return View(artist);
        }

        [HttpPost]
        public ActionResult Edit(Artist artist)
        {
            if (!ModelState.IsValid)
                return View(artist);

            repository.Update(artist);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}