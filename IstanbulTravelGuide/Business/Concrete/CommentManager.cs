using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetByPost(int postId)
        {
            return _commentDal.GetList(p => p.PostId == postId);
        }

        public List<Comment> GetByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int commentId)
        {
            throw new NotImplementedException();
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Modify(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Remove(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
