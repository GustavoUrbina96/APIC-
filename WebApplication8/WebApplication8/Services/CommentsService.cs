using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Repositories;
using WebApplication8.Models;
namespace WebApplication8.Services
{
    public class CommentsService
    {
        private CommentsRepository _commentsRepository;

        public CommentsService(CommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }

        public List<CommentsModel> GetAllComments()
        {
            return _commentsRepository.GetAllComments();
        }

        public CommentsModel GetCommentByID(int id)
        {
            return _commentsRepository.GetCommentByID(id);
        }

        public void AddComment(CommentsModel newComment)
        {
            _commentsRepository.AddComment(newComment);
        }

        public void UpdateComment(int id, CommentsModel UpdateComment)
        {
            _commentsRepository.UpdateComment(id, UpdateComment);
        }

        public void Deletecomment(int id)
        {
            _commentsRepository.DeleteComments(id);
        }
    }
}
