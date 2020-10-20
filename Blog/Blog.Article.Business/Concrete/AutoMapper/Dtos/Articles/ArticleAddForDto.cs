using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles
{
    public class ArticleAddForDto
    {
        public string Title { get; set; }
        public int CategoryID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
