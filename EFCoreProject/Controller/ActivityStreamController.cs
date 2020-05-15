using EFCoreProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreProject.Controller
{
    class ActivityStreamController
    {
        private readonly EFDbContext _context;
        public ActivityStreamController(EFDbContext context)
        {
            this._context = context;
        }

        public void Add(ActivityStream activityStream)
        {
            this._context.ActivityStream.Add(activityStream);
            this._context.SaveChanges();
        }

        public void AddRange(IEnumerable<ActivityStream> activityStreams)
        {
            this._context.ActivityStream.AddRange(activityStreams);
            this._context.SaveChanges();
        }

        public ActivityStream Get(Guid id)
        {
            return this._context.ActivityStream.Find(id);
        }

        public List<ActivityStream> GetAll()
        {
            return this._context.ActivityStream.ToList();
        }
    }
}
