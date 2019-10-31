using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}