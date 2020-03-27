using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.ViewComponents
{
    public class CommentAddViewComponent :ViewComponent
    {
        private ICommentService _commentManager;

        public CommentAddViewComponent(ICommentService commentManager)
        {
            _commentManager = commentManager;
        }
        public IViewComponentResult Invoke(Comment comment)
        {
            
            _commentManager.Add(comment);
            return View();
        
        }
    }
}
