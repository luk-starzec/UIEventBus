﻿using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Shop.Events
{
    public record ShopSoldEvent(int Id) : IComponentEvent;
}
