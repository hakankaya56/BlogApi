using Blog.Article.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.DataAccess.Abstract
{
   public interface IArticleDal:IEntityRepository<Blog.Article.Entities.Concrete.Article>
    {
    }
}
