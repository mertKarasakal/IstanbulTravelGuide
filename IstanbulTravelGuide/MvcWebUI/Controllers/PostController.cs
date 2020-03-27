using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;
        private ICommentService _commentManager;
        private IstanbulTGContext context = new IstanbulTGContext();

        public PostController(IPostService postService, ICommentService commentManager)
        {
            _postService = postService;
            _commentManager = commentManager;
        }

        public IActionResult Index(int categoryId)
        {
            var model = new PostListViewModel
            {
                Posts = categoryId>0? _postService.GetByCategory(categoryId):_postService.GetAll()
            };
            //return View(_postService.GetListPostDetailDto());
            return View(model);
        }

        public IActionResult Search(string key)
        {
            var model = _postService.GetByString(key);
            //return View(_postService.GetListPostDetailDto());
            return View(model);
        }

        public IActionResult Detail(int postId)
        {
            var model = new PostDetailViewModel
            {
                PostDetailDto = _postService.GetPostDetailDto(postId),
                Comment = new Comment()
            };
            //return View(_postService.GetListPostDetailDto());
           // ViewBag.PostId = postId;// new SelectList(context.Photos, "Id", "Description");

            return View(model);

         //   return View(_postService.GetPostDetailDto(postId));
            //return View(_postService.GetById(postId));
        }


        [HttpPost]
        public IActionResult Detail(Comment comment,int postId)
        {
            comment.Date = DateTime.Now;
            comment.PostId = postId; //SIMDILIK
          //  comment.UserName = "MERTKARASAKAL"; //SIMDILIK
           // comment.Email = "asf";
         _commentManager.Add(comment);
         return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Add(post);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View(post);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var post = _postService.GetById((int)id);
            if (post == null)
            {
                return new NotFoundResult();
            }

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Modify(post);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View(post);

        }

        public ActionResult Delete(int? id)
        {

            var post = _postService.GetById((int)id);
            if (post == null)
            {
                return new NotFoundResult();
            }

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View(post);
        }

        // POST: Kitap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Remove(post);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            ViewBag.PhotoId = new SelectList(context.Photos, "Id", "Description");
            return View(post);
        }
    }
}