using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Article.Business.Abstract.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Article.WebApi.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Articles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Articles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
