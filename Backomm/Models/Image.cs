using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class Image : BaseModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}