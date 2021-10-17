using ComponentBus;

namespace BlazorApp.BasicExample
{
    public record BasicEvent(int Id, string Text) : IComponentEvent;
}
