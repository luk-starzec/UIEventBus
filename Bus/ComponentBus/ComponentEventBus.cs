using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentBus
{
    public class ComponentEventBus
    {
        private readonly List<(Type type, object handler)> registered
            = new List<(Type type, object handler)>();

        public void Subscribe<T>(Action<IComponentEvent> eventHandler) where T : IComponentEvent
            => Add<T>(eventHandler);
        public void Subscribe<T>(Func<IComponentEvent, Task> eventHandler) where T : IComponentEvent
            => Add<T>(eventHandler);

        public void Unsubscribe(Action<IComponentEvent> eventHandler)
            => Remove(eventHandler);
        public void Unsubscribe(Func<IComponentEvent, Task> eventHandler)
            => Remove(eventHandler);
        public void UnsubscribeAll() => registered.Clear();

        public async Task Publish<T>(T componentEvent) where T : IComponentEvent
            => await Invoke<T>(componentEvent);


        private void Add<T>(Delegate eventHandler)
        {
            if (eventHandler is null)
                return;

            registered.Add((typeof(T), eventHandler));
        }


        private void Remove<T>(T eventHandler) where T : Delegate
        {
            if (eventHandler is null)
                return;

            var items = registered
                .Where(r => r.handler as T == eventHandler)
                .ToArray();

            foreach (var item in items)
                registered.Remove(item);

        }

        private async Task Invoke<T>(T componentEvent) where T : IComponentEvent
        {
            if (componentEvent is null)
                return;

            var eventType = typeof(T);

            var handlers = registered
                .Where(r => r.type == eventType)
                .Select(r => r.handler)
                .ToArray();

            foreach (var handler in handlers)
            {
                if (handler is Action<T> action)
                    await Task.Run(() => action.Invoke(componentEvent));
                if (handler is Func<T, Task> func)
                    await func.Invoke(componentEvent);
            }
        }
    }
}
