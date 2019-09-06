using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Services;
using WebApplication8.Models;
namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {

        private CommentsService _commentsService;

        public CommentsController(CommentsService postService)
        {
            _commentsService = postService;
        }


        // GET: api/Comments
        [HttpGet]
        public IEnumerable<CommentsModel> Get()
        {
            return _commentsService.GetAllComments();
        }

        // GET: api/Comments/5
        [HttpGet("{id}", Name = "GetCommentByID")]
        public CommentsModel Get(int id)
        {
            return _commentsService.GetCommentByID(id);
        }
        
        // POST: api/Comments
        [HttpPost]
        public void Post([FromBody]CommentsModel newComment)
        {
            _commentsService.AddComment(newComment);
        }
        
        // PUT: api/Comments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CommentsModel Comment)
        {
            _commentsService.UpdateComment(id, Comment);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _commentsService.Deletecomment(id);
        }
    }
}
