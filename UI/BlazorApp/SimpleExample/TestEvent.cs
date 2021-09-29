using ComponentBus;

namespace BlazorApp.SimpleExample
{
    public record SimpleEvent(int Id, string Text) : IComponentEvent;
}
