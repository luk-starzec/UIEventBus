using ComponentBus;

namespace Catalog.Events
{
    public record CatalogChangedEvent(int Id, string Name, string Category, string Color, string Description) : IComponentEvent;
}
