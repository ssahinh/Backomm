using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class County : BaseModel
    {
        public string Title { get; set; }

        public City City { get; set; }
    }
}