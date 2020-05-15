using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Model
{
    public class ActivityDetail
    {
        public Guid Id { get; set; }
        public Guid ActivityStreamId { get; set; }
        public Guid VideoId { get; set; }
        public UserAction Action { get; set; }
        public DateTime Time { get; set; }

        public enum UserAction
        {
            Upload,
            Edit,
            Comment
        }

        public virtual ActivityStream ActivityStream { get; set; }
        public virtual Video Video { get; set; }
    }
}
