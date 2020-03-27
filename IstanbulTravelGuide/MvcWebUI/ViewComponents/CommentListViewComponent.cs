using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;

namespace MvcWebUI.ViewComponents
{
    public class CommentListViewComponent : ViewComponent
    {
        private ICommentService _commentManager;

        public CommentListViewComponent(ICommentService commentManager)
        {
            _commentManager = commentManager;
        }
        public IViewComponentResult Invoke(int? postId)
        {
            var model = new CommentListViewModel
            {
                Comments = _commentManager.GetByPost((int)postId)
            };
            return View(model);
            //IstanbulTGContext context = new IstanbulTGContext();
            //var yorumlar = context.Comments.ToList();
            //return View(_commentManager.GetByPost((int)postId));
            //return View(yorumlar);
        }
    }
}
