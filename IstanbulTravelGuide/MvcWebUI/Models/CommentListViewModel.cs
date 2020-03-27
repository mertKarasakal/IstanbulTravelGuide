using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class CommentListViewModel
    {
        public List<Comment> Comments { get; set; }
    }
}
