using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Calculator.Summary.Events
{
    public record SummaryStyleChangeEvent(Guid Id, string Color, bool IsInput, bool IsResult) : IComponentEvent;

}
