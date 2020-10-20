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
            using (var scope = new TransactionScope())
            {
                try
                {
                    var category = await _categoryService.GetCategoryByName(articleAddForDto.Category);

                    var article = _mapper.Map<Article.Entities.Concrete.Article>(articleAddForDto);
                    article.CategoryID = category.Id;

                    var addedArticle = await _articleDal.AddAsync(article);
                    scope.Complete();
                    return addedArticle;
                }
                catch (Exception e)
                {
                    scope.Dispose();
                    throw new Exception(e.InnerException != null ? e.InnerException.Message : e.Message);
                }
            }
        }

        public void DeleteArticle(int id)
        {
            var article = GetArticleById(id);
            _articleDal.Delete(new Entities.Concrete.Article { Id = article.Result.Id });
        }

        public async Task<ArticleDto> GetArticleById(int id)
        {
            var article = await _queryableRepoArticle.GetAll.Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
            if (article == null)
            {
                throw new Exception("Article did not find");
            }
            var articleDto = _mapper.Map<ArticleDto>(article);
            return articleDto;
        }

        public async Task<List<ArticleListForDto>> GetArticleList()
        {
            var articleList = await _queryableRepoArticle.GetAll.Include(a => a.Category).ToListAsync();
            var articleListDto = _mapper.Map<List<ArticleListForDto>>(articleList);
            return articleListDto;
        }

        public async Task<Entities.Concrete.Article> UpdateArticle(ArticleUpdateForDto articleUpdateForDto)
        {
            using (var scope = new TransactionScope())
            {
                try
                {  
                    var articleDto = await GetArticleById(articleUpdateForDto.Id);

                    var category = await _categoryService.GetCategoryByName(articleUpdateForDto.Category);
                    var article = _mapper.Map<Article.Entities.Concrete.Article>(articleUpdateForDto);
                    article.CategoryID = category.Id;

                    var updatedArticle =  _articleDal.Update(article);
                    scope.Complete();
                    return updatedArticle;
                }
                catch (Exception e)
                {
                    scope.Dispose();
                    throw new Exception(e.InnerException != null ? e.InnerException.Message : e.Message);
                }
            }
        }
    }
}