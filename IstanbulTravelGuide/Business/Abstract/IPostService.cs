using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetByCategory(int categoryId);
        Post GetById(int postId);
        List<PostDetailDto> GetListPostDetailDto();
        PostDetailDto GetPostDetailDto(int postId);
        List<Post> GetByString(string key);

        void Add(Post post);
        void Modify(Post post);
        void Remove(Post post);
    }
}
