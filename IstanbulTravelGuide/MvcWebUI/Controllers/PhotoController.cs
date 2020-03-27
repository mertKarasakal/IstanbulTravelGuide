using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcWebUI.Controllers
{
    public class PhotoController : Controller
    {
        private IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            
            return View(_photoService.GetAll());
        }
       

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Photo photo)
        {
            if (ModelState.IsValid)
            {
                _photoService.Add(photo);
                return RedirectToAction("Index");
            }
            return View(photo);

        }

      

        public ActionResult Delete(int? id)
        {

            var photo = _photoService.GetById((int)id);
            if (photo == null)
            {
                return new NotFoundResult();
            }

            return View(photo);
        }

        // POST: Kitap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Photo photo)
        {
            if (ModelState.IsValid)
            {
                _photoService.Remove(photo);
                return RedirectToAction("Index");
            }

            return View(photo);
        }
    }
}