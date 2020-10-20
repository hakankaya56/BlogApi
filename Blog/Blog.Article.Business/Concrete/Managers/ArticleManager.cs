using AutoMapper;
using Blog.Article.Business.Abstract.Services;
using Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles;
using Blog.Article.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using System.Transactions;
using Blog.Article.Business.ValidationRules.FluentValidation;
using FluentValidation;

namespace Blog.Article.Business.Concrete.Managers
{
    public class ArticleManager : IArticleServices
    {
        private readonly IQueryableRepo<Entities.Concrete.Article> _queryableRepoArticle;
        private readonly ICategoryService _categoryService;
        private readonly IArticleDal _articleDal;
        private readonly IMapper _mapper;

        public ArticleManager(IQueryableRepo<Entities.Concrete.Article> queryableRepoArticle, IArticleDal articleDal, ICategoryService categoryService, IMapper mapper)
        {
            _queryableRepoArticle = queryableRepoArticle;
            _categoryService = categoryService;
            _articleDal = articleDal;
            _mapper = mapper;
        }
        public async Task<Entities.Concrete.Article> AddArticle(ArticleAddForDto articleAddForDto)
        {
            var article = _mapper.Map<Article.Entities.Concrete.Article>(articleAddForDto);
            var articleValidator = new ArticleValidator();
            var resutltValidator = articleValidator.Validate(article);
            if (resutltValidator.Errors.Count > 0)
            {
                throw new ValidationException(resutltValidator.Errors);
            }
            var addedArticle = await _articleDal.AddAsync(article);

            return addedArticle;

        }

        public void DeleteArticle(int id)
        {
            var article = GetArticleById(id);
            _articleDal.Delete(new Entities.Concrete.Article { Id = article.Result.Id });
        }

        public async Task<Article.Entities.Concrete.Article> GetArticleById(int id)
        {
            var article = await _queryableRepoArticle.GetAll.Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
            if (article == null)
            {
                throw new Exception("Article did not find");
            }
            
            return article;
        }

        public async Task<List<ArticleListForDto>> GetArticleList()
        {
            var articleList = await _queryableRepoArticle.GetAll.Include(a => a.Category).ToListAsync();
            var articleListDto = _mapper.Map<List<ArticleListForDto>>(articleList);
            return articleListDto;
        }

        public async Task<List<ArticleListForDto>> GetArticleSearchByTitle(string value)
        {
            var articleList = await _queryableRepoArticle.GetAll.Where(a => a.Title.Contains(value)).Include(a => a.Category).ToListAsync();
            var articleListDto = _mapper.Map<List<ArticleListForDto>>(articleList);
            return articleListDto;
        }

        public async Task<Entities.Concrete.Article> UpdateArticle(ArticleUpdateForDto articleUpdateForDto)
        {
            var article = await GetArticleById(articleUpdateForDto.Id);

            article.Title = articleUpdateForDto.Title;
            article.Content = articleUpdateForDto.Content;
            article.CategoryID = articleUpdateForDto.CategoryID;
            article.UpdatedDate = articleUpdateForDto.UpdatedDate;


            var articleValidator = new ArticleValidator();
            var resutltValidator = articleValidator.Validate(article);
            if (resutltValidator.Errors.Count > 0)
            {
                throw new ValidationException(resutltValidator.Errors);
            }
            var updatedArticle = _articleDal.Update(article);

            return updatedArticle;

        }
    }
}