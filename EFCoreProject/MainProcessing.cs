using EFCoreProject.Controller;
using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class MainProcessing
    {
        private EFDbContext _context;
        private UserController userController;
        private VideoController videoController;
        private CommentController commentController;
        private ActivityStreamController activityStreamController;
        public MainProcessing()
        {
            var contextOptions = new DbContextOptionsBuilder<EFDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this._context = new EFDbContext(contextOptions);
            userController = new UserController(this._context);
            videoController = new VideoController(this._context);
            commentController = new CommentController(this._context);
            activityStreamController = new ActivityStreamController(this._context);
        }

        public List<String> GetTitleOfAllVideo()
        {
            return this.videoController.GetTitleOfAllVideo();
        }

        public List<String> GetTitleOfvideosAuthorByUser(Guid userId)
        {

            return this.GetTitleOfvideosAuthorByUser();
        }

        public List<String> GetTitleOfvideosAuthorByUser(string userName)
        {
            User user = userController.Get(userName);
            return this.videoController.GetTitleOfvideosAuthorByUser(user.Id);
        }

        public List<String> GetTitleOfvideosAuthorByUser(Guid userId)
        {

            return this.GetTitleOfvideosAuthorByUser();
        }

        public List<String> GetTitleOfVideosAuthorByUserOneThatUserTwoComment(Guid userId1, Guid userId2)
        {
            var result = this._context.Video
                .Include(x => x.Comments)
                .Where(v => v.UserId == userId1 && v.Comments.Any(c => c.UserId == userId2))
                .Select(v => v.Title).ToList();
            return result;
        }

        public List<String> GetTitleOfVideosReceivedCommentLastWeek()
        {
            var result = this._context.Video
                .Include(x => x.Comments)
                .AsEnumerable()
                .Where(x => x.Comments.Any(c => c.Time >= DateTime.Now.AddDays(-7)))
                .Select(v => v.Title).ToList();
            return result;
        }

        public Object GetVideoReceivedTheMostComment()
        {
            var result = this._context.Video
                .Include(x => x.Comments)
                .SelectMany(x => x.Comments)
                .GroupBy(x => x.Id)
                .Select(x => new { Id = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();
            return result;
        }
    }
}
