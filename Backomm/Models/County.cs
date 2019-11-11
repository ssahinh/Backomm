using System.Collections.Generic;

namespace Backomm.Models
{
    public class County : BaseModel
    {
        public string Title { get; set; }

        public City City { get; set; }
        
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}