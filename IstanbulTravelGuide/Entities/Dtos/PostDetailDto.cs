using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dtos
{
    public class PostDetailDto : IDto
    {
        public int Id { get; set; }
      //  public int CategoryId { get; set; }
        public string Description { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }

    }
}
