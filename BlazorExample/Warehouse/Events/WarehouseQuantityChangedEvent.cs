using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Warehouse.Events
{
    public record WarehouseQuantityChangedEvent(int Id, int Quantity) : IComponentEvent;
}
