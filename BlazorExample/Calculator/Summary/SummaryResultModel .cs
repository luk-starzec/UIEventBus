using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Calculator.Summary
{
    public class SummaryResultModel
    {
        public Guid Id { get; set; }
        public string Operator { get; set; }
        public Dictionary<Guid, string> Inputs { get; set; }
        public Dictionary<Guid, int> Values { get; set; }
        public decimal? Result { get; set; }
    }
}
