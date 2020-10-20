using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Blog.Article.Business.ValidationRules.FluentValidation
{
   public class ArticleValidator:AbstractValidator<Article.Entities.Concrete.Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.Title).NotEmpty().Length(1,50);
            RuleFor(a => a.Content).NotEmpty();
            RuleFor(a => a.CategoryID).NotEmpty();
           
        }
    }
}
