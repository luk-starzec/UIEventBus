using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Summary.Events
{
    public record SummaryStyleChangeEvent(Guid Id, string Color, bool IsArgument, bool IsResult) : IComponentEvent;

}
