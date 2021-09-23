using System;
using System.Collections.Generic;

namespace BlazorApp.Calculator.Summary
{
    public class SummaryResultModel
    {
        public Guid Id { get; set; }
        public string Operator { get; set; }
        public Dictionary<Guid, string> Arguments { get; set; }
        public Dictionary<Guid, int> Values { get; set; }
        public decimal? Result { get; set; }
    }
}
