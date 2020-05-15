using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Model
{
    public class ActivityStream
    {
        
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        public virtual ICollection<ActivityDetail> ActivityDetails { get; set; }
        public ActivityStream()
        {
            ActivityDetails = new HashSet<ActivityDetail>(); 
        }
    }
}
