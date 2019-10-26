using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        
        public string About { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}