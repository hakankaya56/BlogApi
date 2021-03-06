﻿using Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Article.Business.Abstract.Services
{
    public interface IArticleServices
    {
        Task<Entities.Concrete.Article> GetArticleById(int id);
        Task<List<ArticleListForDto>> GetArticleList();
        Task<List<ArticleListForDto>> GetArticleSearchByTitle(string value);
        Task<Article.Entities.Concrete.Article> AddArticle(ArticleAddForDto articleAddForDto);
        Task<Entities.Concrete.Article> UpdateArticle(ArticleUpdateForDto articleUpdateForDto);
        void DeleteArticle(int id);

    }
}
