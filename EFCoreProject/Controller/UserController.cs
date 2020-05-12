using EFCoreProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Controller
{
    public class UserController
    {
        private EFDbContext _context;
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
    }
}
