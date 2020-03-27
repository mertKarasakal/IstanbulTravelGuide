using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        List<Comment> GetByPost(int postId);
        List<Comment> GetByUser(int userId);
        Comment GetById(int commentId);
        void Add(Comment comment);
        void Modify(Comment comment);
        void Remove(Comment comment);
    }
}
