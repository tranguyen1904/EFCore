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
                .UseInMemoryDatabase("Database")
                .Options;
            this._context = new EFDbContext(contextOptions);
            userController = new UserController(this._context);
            videoController = new VideoController(this._context);
            commentController = new CommentController(this._context);
            activityStreamController = new ActivityStreamController(this._context);
        }

        #region Add Method

        public void AddVideo(Video video)
        {
            this.videoController.Add(video);
        }

        public void AddVideos(IEnumerable<Video> video)
        {
            this.videoController.AddRange(video);
        }

        public void AddUser(User user)
        {
            this.userController.Add(user);
        }

        public void AddUsers(IEnumerable<User> users)
        {
            this.userController.AddRange(users);
        }

        public void AddComment(Comment comment)
        {
            this.commentController.Add(comment);
        }

        public void AddComments(IEnumerable<Comment> comments)
        {
            this.commentController.AddRange(comments);
        }

        public void AddActivityStream(ActivityStream activityStream)
        {
            this.activityStreamController.Add(activityStream);
        }

        public void AddAvtivityStreams(IEnumerable<ActivityStream> activityStreams)
        {
            this.activityStreamController.AddRange(activityStreams);
        }
        #endregion

        #region Get Method

        public List<String> GetTitleOfAllVideo()
        {
            return this.videoController.GetTitleOfAllVideo();
        }

        public List<string> GetTitleOfvideosAuthorByUser(User user)
        {
            return this.videoController.GetTitleOfvideosAuthorByUser(user);
        }

        public List<string> GetTitleOfvideosAuthorByUserId(Guid userId)
        {
            User user = userController.GetById(userId);
            return GetTitleOfvideosAuthorByUser(user);
        }

        public List<string> GetTitleOfvideosAuthorByUserName(string userName)
        {
            User user = userController.GetByName(userName);
            return GetTitleOfvideosAuthorByUser(user);
        }

        public List<string> GetTitleOfvideosAuthorByUserMail(string userMail)
        {
            User user = userController.GetByEmail(userMail);
            return GetTitleOfvideosAuthorByUser(user);
        }

        public List<string> GetTitleOfVideosAuthorByUserOneThatUserTwoComment(User user1, User user2)
        {
            return this.videoController.GetTitleOfVideosAuthorByUserOneThatUserTwoComment(user1, user2);
        }

        public List<string> GetTitleOfVideosAuthorByUserOneThatUserTwoComment_ByName(string userName1, string userName2)
        {
            User user1 = this.userController.GetByName(userName1);
            User user2 = this.userController.GetByName(userName2);
            return GetTitleOfVideosAuthorByUserOneThatUserTwoComment(user1, user2);
        }

        public List<string> GetTitleOfVideosAuthorByUserOneThatUserTwoComment_ByMail(string userMail1, string userMail2)
        {
            User user1 = this.userController.GetByName(userMail1);
            User user2 = this.userController.GetByName(userMail2);
            return GetTitleOfVideosAuthorByUserOneThatUserTwoComment(user1, user2);
        }

        public List<String> GetTitleOfVideosReceivedCommentLastWeek()
        {
            return this.videoController.GetTitleOfVideosReceivedCommentLastWeek();
        }

        public Object GetVideoReceivedTheMostComment()
        {
            return this.videoController.GetVideoReceivedTheMostComment();
        }
        #endregion
    }
}
