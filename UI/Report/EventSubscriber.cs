using Catalog.Events;
using Warehouse.Events;
using Shop.Events;
using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public class EventSubscriber : IEventSubscriber
    {
        private readonly ComponentEventBus bus;

        public EventSubscriber(ComponentEventBus bus)
        {
            this.bus = bus;
        }

        public void SubscribeAll(Action<IComponentEvent> handler)
        {
            bus.Subscribe<CatalogAddedEvent>(handler);
            bus.Subscribe<CatalogDeleteBeginEvent>(handler);
            bus.Subscribe<CatalogDeleteEndEvent>(handler);
            bus.Subscribe<CatalogEditBeginEvent>(handler);
            bus.Subscribe<CatalogEditEndEvent>(handler);
            bus.Subscribe<CatalogForSaleChangedEvent>(handler);
            bus.Subscribe<CatalogRemovedEvent>(handler);

            bus.Subscribe<WarehouseQuantityChangedEvent>(handler);

            bus.Subscribe<ShopSoldEvent>(handler);
        }

        public void UnsubscribeAll(Action<IComponentEvent> handler)
        {
            bus.Unsubscribe(handler);
        }
    }
}
