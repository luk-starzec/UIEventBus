using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentBus
{
    public class ComponentEventBus
    {
        private readonly List<KeyValuePair<Type, Action<IComponentEvent>>> registered
            = new List<KeyValuePair<Type, Action<IComponentEvent>>>();

        public void Subscribe<T>(Action<IComponentEvent> eventHandler)
        {
            if (eventHandler is null)
                return;

            registered.Add(new KeyValuePair<Type, Action<IComponentEvent>>(typeof(T), eventHandler));
        }

        public async Task Publish<T>(T componentEvent) where T : IComponentEvent
        {
            if (componentEvent == null)
                return;

            var eventType = typeof(T);
            var subscribers = registered.Where(r => r.Key == eventType).ToArray();

            foreach (var subscriber in subscribers)
                await Task.Run(() => subscriber.Value.Invoke(componentEvent));
        }

    }
}
