using Blog.Article.Core.DataAccess;
using Blog.Article.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
