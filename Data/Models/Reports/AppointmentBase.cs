using System;

namespace RobertOgden.Data.Models.Reports
{
    internal abstract class AppointmentBase : ReportBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}