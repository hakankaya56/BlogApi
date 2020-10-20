using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles
{
   public class ArticleListForDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
