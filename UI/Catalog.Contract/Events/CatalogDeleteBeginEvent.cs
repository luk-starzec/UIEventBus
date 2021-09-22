using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Events
{
    public record CatalogDeleteBeginEvent(int Id) : IComponentEvent;
}
