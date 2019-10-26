using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public ICollection<Group> Groups { get; set; }
        
    }
}