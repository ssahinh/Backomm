using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class FacebookUser : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
    }
}