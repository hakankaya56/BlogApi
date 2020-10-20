using Blog.Article.Business.Abstract.Services;
using Blog.Article.DataAccess.Abstract;
using Blog.Article.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Article.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task<Category> GetCategoryByName(string name)
        {
            var category = await _categoryDal.GetAsync(c => c.Name == name);
            if (category == null)
            {
                throw new Exception(name + "category did not find");
            }
            return category;
        }
    }
}
