using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreProject.Controller
{
    class VideoController
    {
        private readonly EFDbContext _context;
        public VideoController(EFDbContext context)
        {
            this._context = context;
        }

        public void Add(Video video)
        {
            this._context.Video.Add(video);
            this._context.SaveChanges();
        }

        public void AddRange(List<Video> videos)
        {
            this._context.Video.AddRange(videos);
            this._context.SaveChanges();
        }

        public Video GetVideoById(Guid id)
        {
            return this._context.Video.Find(id);
        }

        public List<Video> GetAllVideo()
        {
            return this._context.Video.ToList();
        }

        public List<String> GetTitleOfAllVideo()
        {
            return this._context.Video.Select(v => v.Title).ToList();
        }

        public List<String> GetTitleOfvideosAuthorByUser(Guid userId)
        {
            var result = this._context.Video.Where(v => v.UserId == userId).Select(v => v.Title).ToList();
            return result;
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
                .Select(v=>v.Title).ToList();
            return result;
        }

        public Object GetVideoReceivedTheMostComment()
        {
            var result = this._context.Video
                .Include(x => x.Comments)
                .SelectMany(x => x.Comments)
                .GroupBy(x => x.Id)
                .Select(x => new { Id = x.Key, Count = x.Count() })
                .OrderByDescending(x=>x.Count)
                .FirstOrDefault();
            return result;
        }
    }
}
