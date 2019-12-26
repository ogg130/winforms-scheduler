using System;

namespace RobertOgden.Data.Models
{
    public abstract class TimeStampBase
    {
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}