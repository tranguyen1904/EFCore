using EFCoreProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreProject.Controller
{
    class CommentController
    {
        private readonly EFDbContext _context;

        public CommentController(EFDbContext context)
        {
            this._context = context;
        }

        public void Add(Comment comment)
        {
            this._context.Comment.Add(comment);
        }

        public void AddRange(List<Comment> comments)
        {
            this._context.Comment.AddRange(comments);
        }

        public Comment Get(Guid id)
        {
            return this._context.Comment.Find(id);
        }

        public List<Comment> GetAll()
        {
            return this._context.Comment.ToList();
        }
    }
}
