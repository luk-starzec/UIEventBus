﻿using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Argument.Events
{
    public record ArgumentAddEvent(Guid Id, string Name) : IComponentEvent;

}