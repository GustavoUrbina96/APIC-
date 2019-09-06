using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
namespace WebApplication8.Repositories
{
    public class PostRepository
    {
        private List<PostModel> Post = new List<PostModel>();

        public List<PostModel> GetAllPost()
        {
            return Post == null ? null : Post;
        }

        public void AddPost(PostModel newPost)
        {
            Post.Add(newPost);
        }

        public PostModel GetPostByID(int id)
        {
            return Post.Find(x => x.Id.Equals(id));
        }

        public void DeletePost(int id)
        {
            Post.Remove(GetPostByID(id));
        }

        public void UpdatePost(int id, PostModel post)
        {
            var updatePost = GetPostByID(id);
            updatePost.Id = post.Id;
            updatePost.Content = post.Content;
        }
    }
}
