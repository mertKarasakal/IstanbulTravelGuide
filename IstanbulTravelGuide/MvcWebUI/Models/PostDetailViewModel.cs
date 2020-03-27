using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;

namespace MvcWebUI.Models
{
    public class PostDetailViewModel
    {
        public PostDetailDto PostDetailDto { get; set; }
        public Comment Comment { get; set; }
    }
}
