using Blog.Article.DataAccess.Abstract;
using Blog.Article.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Article.DataAccess.Concrete
{
    public class EfQueryableRepo<TEntity> : IQueryableRepo<TEntity> where TEntity : class
    {
        private readonly ArticleContext _articleContext;
        private DbSet<TEntity> _entities;
        public EfQueryableRepo(ArticleContext articleContext)
        {
            _articleContext = articleContext;
        }
        public IQueryable<TEntity> GetAll => this.Entities;
        protected virtual DbSet<TEntity> Entities => _entities ?? (_entities = _articleContext.Set<TEntity>());

       
    }
}
