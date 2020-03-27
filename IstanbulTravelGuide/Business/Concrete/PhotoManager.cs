using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PhotoManager : IPhotoService
    {
        private IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public List<Photo> GetAll()
        {
            return _photoDal.GetList();
        }

        public Photo GetByPost(int postId)
        {
            throw new NotImplementedException();
        }

        public Photo GetById(int photoId)
        {
            return _photoDal.Get(p => p.Id == photoId);
        }

        public void Add(Photo photo)
        {
            _photoDal.Add(photo);
        }

        public void Modify(Photo photo)
        {
            throw new NotImplementedException();
        }

        public void Remove(Photo photo)
        {
            _photoDal.Delete(photo);
        }
    }
}
