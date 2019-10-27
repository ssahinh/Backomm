using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Category : BaseModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<Group> Groups { get; set; }
        
    }
}