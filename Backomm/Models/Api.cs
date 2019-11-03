namespace Backomm.Models
{
    public class Api : BaseModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
    }
}