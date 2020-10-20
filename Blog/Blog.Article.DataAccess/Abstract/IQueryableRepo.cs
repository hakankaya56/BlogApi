using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Article.DataAccess.Abstract
{
   public interface IQueryableRepo<T> where T:class
    {
        IQueryable<T> GetAll { get; }
    }
}
