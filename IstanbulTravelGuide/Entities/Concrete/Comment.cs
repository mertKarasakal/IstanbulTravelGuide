using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserName { get; set; }  
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

    }
}
