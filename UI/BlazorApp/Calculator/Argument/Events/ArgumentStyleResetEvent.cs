using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Argument.Events
{
    public record ArgumentStyleResetEvent(Guid Id) : IComponentEvent;

}
