using Catalog.Events;
using ComponentBus;
using Shop.Events;
using System;
using Warehouse.Events;

namespace Report
{
    public interface IEventSubscriber
    {
        void SubscribeAll(Action<IComponentEvent> handler);
        void UnsubscribeAll(Action<IComponentEvent> handler);
    }


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
