using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Article.Business.Abstract.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components.Routing;
using Blog.Article.Business.Concrete.AutoMapper.Dtos.Articles;

namespace Blog.Article.WebApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleServices _articleService;
        public ArticlesController(IArticleServices articleService)
        {
            _articleService = articleService;
        }
        // GET: api/Articles
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var articleList = await _articleService.GetArticleList();
            return Ok(articleList);
        }

        // GET: api/Articles/5
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Search")]
        public async Task<IActionResult> SearchArticle(string value)
        {
            var foundArticles = await _articleService.GetArticleSearchByTitle(value);
            return Ok(foundArticles);
        }

        // POST: api/Articles
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ArticleAddForDto articleAddForDto)
        {
            var addedArticle = await _articleService.AddArticle(articleAddForDto);
            return Ok(addedArticle);
        }

        // PUT: api/Articles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]ArticleUpdateForDto articleUpdateForDto)
        {
            articleUpdateForDto.Id = id;
            var updatedArticle = await _articleService.UpdateArticle(articleUpdateForDto);
            return Ok(updatedArticle);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _articleService.DeleteArticle(id);
          return   Ok("Success");
        }
    }
}
