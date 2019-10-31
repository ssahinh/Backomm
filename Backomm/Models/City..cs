using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
    }
}