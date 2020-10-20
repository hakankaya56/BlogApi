using Blog.Article.Core.DataAccess.EfEntityFramework;
using Blog.Article.DataAccess.Abstract;
using Blog.Article.DataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.DataAccess.Concrete
{
   public class EfArticleDal:EfEntityRepositoryBase<Article.Entities.Concrete.Article, ArticleContext>, IArticleDal
    {
    }
}
