using System;

namespace Report
{
    public record ReportModel
    {
        public DateTime Time { get; init; }
        public string Description { get; init; }

        public ReportModel(string description)
        {
            Time = DateTime.Now;
            Description = description;
        }
    }
}
