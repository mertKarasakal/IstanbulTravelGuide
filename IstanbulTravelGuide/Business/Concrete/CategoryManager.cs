using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(p => p.Id == categoryId);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Modify(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Remove(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
