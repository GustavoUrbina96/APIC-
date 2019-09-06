using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;
namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {

        private PostService _postService;

        public PostController(PostService postService)
        {
            _postService = postService;
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<PostModel> Get()
        {
            var temp = _postService.GetAllPost();
            return _postService.GetAllPost();
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "GetPost")]
        public PostModel Get(int id)
        {
            return _postService.GetPostByID(id);
        }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody]PostModel newPost)
        {
            _postService.AddPost(newPost);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PostModel post)
        {
            _postService.UpdatePost(id, post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postService.DeletePost(id);
        }
    }
}
