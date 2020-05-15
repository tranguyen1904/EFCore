using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public User GetById(Guid guid)
        {
            return this._context.User.Find(guid);
        }

        public User GetByName(String name)
        {
            return this._context.User.Where(x => x.Nickname == name).FirstOrDefault();
        }

        public User GetByEmail(String mail)
        {
            return this._context.User.Where(x => x.Mail == mail).FirstOrDefault();
        }

        public void Add(User user)
        {
            this._context.User.Add(user);
            this._context.SaveChanges();
        }

        public void AddRange(IEnumerable<User> users)
        {
            this._context.User.AddRange(users);
            this._context.SaveChanges();
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
