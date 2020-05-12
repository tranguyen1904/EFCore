using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Model
{
    public class Video
    {
        public enum VideoQuality
        {
            SD,
            HD
        }
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public VideoQuality Quality { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<ActivityStream> ActivityStreams { get; set; }

        public Video()
        {
            this.Comments = new HashSet<Comment>();
            this.ActivityStreams = new HashSet<ActivityStream>();
        }

    }
}
