using System;

namespace Report
{
    public record ReportLogModel
    {
        public DateTime Time { get; init; }
        public string Description { get; init; }

        public ReportLogModel(string description)
        {
            Time = DateTime.Now;
            Description = description;
        }
    }
}
