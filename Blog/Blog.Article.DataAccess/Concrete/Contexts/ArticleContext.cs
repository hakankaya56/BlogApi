using Blog.Article.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.DataAccess.Concrete.Contexts
{
    public class ArticleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FB1GOR8;Database=ARTICLE_DB;Trusted_Connection=yes;");
        }

        public virtual DbSet<Article.Entities.Concrete.Article>  Articles{ get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
