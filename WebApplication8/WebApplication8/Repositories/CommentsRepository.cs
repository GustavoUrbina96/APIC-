using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
namespace WebApplication8.Repositories
{
    public class CommentsRepository
    {
        private List<CommentsModel> Comments = new List<CommentsModel>();

        public List<CommentsModel> GetAllComments()
        {
            return Comments == null ? null : Comments;
        }

        public void AddComment(CommentsModel newComment)
        {
            Comments.Add(newComment);
        }

        public CommentsModel GetCommentByID(int id)
        {
            return Comments.Find(x => x.Id.Equals(id));
        }

        public void DeleteComments(int id)
        {
            Comments.Remove(GetCommentByID(id));
        }

        public void UpdateComment(int id, CommentsModel comment)
        {
            var updateComments = GetCommentByID(id);
            updateComments.Id = comment.Id;
            updateComments.Comment = comment.Comment;
        }
    }
}
