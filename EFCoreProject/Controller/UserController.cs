using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreProject.Controller
{
    public class UserController
    {
        private readonly EFDbContext _context;
        public UserController(EFDbContext context)
        {
            this._context = context;
        }

        public User Get(Guid guid)
        {
            return this._context.User.Find(guid);
        }

        public void Add(User user)
        {

            this._context.User.Add(user);
        }

        public void AddRange(List<User> users)
        {
            this._context.User.AddRange(users);
        }

        public List<User> GetAllUserAuthorHDVideo()
        {
            var result = this._context.User.Include(x => x.Videos)
                .Where(x => x.Videos.Any(x => x.Quality == Video.VideoQuality.HD))
                .ToList();
            return result;
        }
    }
}
