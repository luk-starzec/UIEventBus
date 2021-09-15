using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Catalog.Events
{
    public record CatalogForSaleChangedEvent(int Id, bool ForSale) : IComponentEvent;
}
