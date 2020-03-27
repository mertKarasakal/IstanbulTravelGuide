using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService _commentManager;

        public CommentController(ICommentService commentManager)
        {
            _commentManager = commentManager;
        }

        public IActionResult Create(Comment comment)
        {
            _commentManager.Add(comment);
            return View();
        }
    }
}