using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPhotoService
    {
        List<Photo> GetAll();
        Photo GetByPost(int postId);
        Photo GetById(int photoId);
        void Add(Photo photo);
        void Modify(Photo photo);
        void Remove(Photo photo);
    }
}
