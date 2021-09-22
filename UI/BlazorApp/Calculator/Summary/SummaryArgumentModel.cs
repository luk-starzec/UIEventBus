using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Summary
{
    public class SummaryArgumentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
