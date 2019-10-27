using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Event : BaseModel
    {
        public string About { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}