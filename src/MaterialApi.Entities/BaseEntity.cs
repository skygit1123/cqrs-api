
using System;

namespace MaterialApi.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedDT { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime UpdatedDT { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}