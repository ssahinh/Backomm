using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }

        public City City { get; set; }
    }
}