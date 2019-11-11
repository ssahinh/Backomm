using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class City : BaseModel
    {
        public string Title { get; set; }
        public ICollection<County> Counties { get; set; } 
        
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}