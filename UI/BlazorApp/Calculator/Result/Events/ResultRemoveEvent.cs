using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Result.Events
{
    public record ResultRemoveEvent(Guid Id) : IComponentEvent;

}
