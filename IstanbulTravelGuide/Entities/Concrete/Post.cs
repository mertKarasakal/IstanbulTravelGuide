using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string UserName { get; set; }
        public int PhotoId { get; set; }

        public string Description { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string PhotoUrl { get; set; }
      //  public string PhotoDescription { get; set; }
      //  public string PhotoUrl { get; set; }
       // public Photo Photo { get; set; }
     //   public User User { get; set; }
      //  public Category Category  { get; set; }

    }
}
