using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Nickname { get; set; }
        public string Mail { get; set; }
        [NotMapped]
        public string LoginSession { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ActivityStream ActivityStream { get; set; }

        public User()
        {
            this.Videos = new HashSet<Video>();
            this.Comments = new HashSet<Comment>();
        }

        public override string ToString()
        {
            return $"User Information: \n" +
                $"Nickname: {Nickname}\n" +
                $"Mail: {Mail}\n";
        }
    }
}
