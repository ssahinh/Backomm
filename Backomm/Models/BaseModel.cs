using System;
using System.ComponentModel.DataAnnotations;

namespace Backomm.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime? AddedDate = null;
        
        public DateTime ModifiedDate { get; set; }
        
        public DateTime addedDate
        {
            get
            {
                return this.AddedDate.HasValue
                    ? this.AddedDate.Value
                    : DateTime.Now;
            }

            set { this.AddedDate = value; }
        }
    }
}