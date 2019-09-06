using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Repositories;
using WebApplication8.Models;

namespace WebApplication8.Services
{
    public class PostService
    {
        private PostRepository _postRepository;

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public List<PostModel> GetAllPost()
        {
            return _postRepository.GetAllPost() ;
        }

        public PostModel GetPostByID(int id)
        {
            return _postRepository.GetPostByID(id);
        }

        public void AddPost(PostModel newPost)
        {
            _postRepository.AddPost(newPost);
        }

        public void UpdatePost(int id, PostModel UpdatePost)
        {
            _postRepository.UpdatePost(id, UpdatePost);
        }

        public void DeletePost(int id)
        {
            _postRepository.DeletePost(id);
        }
    }
}
