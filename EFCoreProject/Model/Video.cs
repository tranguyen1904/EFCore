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

        public virtual ICollection<ActivityDetail> ActivityDetails { get; set; }

        public Video()
        {
            this.Comments = new HashSet<Comment>();
            this.ActivityDetails = new HashSet<ActivityDetail>();
        }

        public override string ToString()
        {
            return $"Video information:\n" +
                $"- Title: {this.Title}\n" +
                $"- Time: {this.Time}\n" +
                $"- Qualify: {this.Quality}\n";
            
        }
    }
}
