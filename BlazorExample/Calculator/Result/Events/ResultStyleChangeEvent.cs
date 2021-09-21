using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Calculator.Result.Events
{
    public record ResultStyleChangeEvent(Guid Id, string Color) : IComponentEvent;

}
