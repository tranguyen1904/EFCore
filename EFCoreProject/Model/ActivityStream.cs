using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Model
{
    public class ActivityStream
    {
        public enum UserAction
        {
            Upload,
            Edit,
            Comment
        }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid VideoId { get; set; }
        public UserAction Action { get; set; }
        public DateTime Time { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Video> Videos { get; set; }

        public ActivityStream()
        {
            this.Videos = new HashSet<Video>();
        }
    }
}
