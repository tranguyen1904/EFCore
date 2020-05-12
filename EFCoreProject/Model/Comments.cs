using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace EFCoreProject.Model
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public Guid UserId { get; set; }
        public Guid VideoId { get; set; }

        public virtual User User { get; set; }
        public virtual Video Video { get; set; }
    }
}
