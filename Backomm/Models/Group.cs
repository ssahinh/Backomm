using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Backomm.Models
{
    public class Group : BaseModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public Category Category { get; set; }
        
        public ICollection<ApplicationUser> Users { get; set; }
    }
}