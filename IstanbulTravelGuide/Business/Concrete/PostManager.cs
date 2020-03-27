using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        private IstanbulTGContext _context = new IstanbulTGContext();

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public List<PostDetailDto> GetListPostDetailDto()
        {
            return (from po in _context.Posts
                 join ph in _context.Photos on po.PhotoId equals ph.Id
                 join ca in _context.Categories on po.CategoryId equals ca.Id

                 select new PostDetailDto
                 {
                     Id = po.Id,
                     Description = po.Description,
                     Date = po.Date,
                     Header = po.Header,
                     Text = po.Text,
                     ImageUrl = ph.Url,
                     CategoryName = ca.Name,
                     UserName = po.UserName
                     


                 }).ToList();

        } 
        
        public PostDetailDto GetPostDetailDto(int postId)
        {
            var result = (from po in _context.Posts
                join ph in _context.Photos on po.PhotoId equals ph.Id
                join ca in _context.Categories on po.CategoryId equals ca.Id
                where po.Id == postId

                select new PostDetailDto
                {
                    Id = po.Id,
                    Description = po.Description,
                    Date = po.Date,
                    Header = po.Header,
                    Text = po.Text,
                    ImageUrl = ph.Url,
                    CategoryName = ca.Name,
                    UserName = po.UserName


                }).FirstOrDefault(); //).FirstOrDefault();
            return result;

        }

        public List<Post> GetByString(string key)
        {
            var result = from item in _context.Posts select item;
            if (!string.IsNullOrEmpty(key))
            {
                result = result.Where(
                    m => m.Text.Contains(key) || m.Description.Contains(key) || m.Header.Contains(key));
            }

            return result.ToList();

        }

        public List<Post> GetByCategory(int categoryId)
        {
            return _postDal.GetList(p => p.CategoryId == categoryId);
        }

     

        public Post GetById(int postId)
        {
            return _postDal.Get(p => p.Id == postId);
        }

        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Modify(Post post)
        {
            _postDal.Update(post);
        }

        public void Remove(Post post)
        {
            _postDal.Delete(post);
        }
    }
}
