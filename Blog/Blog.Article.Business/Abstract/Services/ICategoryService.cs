using Blog.Article.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Article.Business.Abstract.Services
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryByName(string name);
    }
}
