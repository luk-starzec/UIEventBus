﻿using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Calculator.Input.Events
{
    public record InputAddEvent(Guid Id, string Name) : IComponentEvent;

}
