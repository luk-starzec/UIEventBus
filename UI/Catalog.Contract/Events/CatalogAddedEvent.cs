using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Events
{
    public record CatalogAddedEvent(CatalogNewItem Item) : IComponentEvent;

    public record CatalogNewItem(int Id, string Name, string Category, string Color, string Description);

}
