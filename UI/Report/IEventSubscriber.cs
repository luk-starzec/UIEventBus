using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public interface IEventSubscriber
    {
        void SubscribeAll(Action<IComponentEvent> handler);
        void UnsubscribeAll(Action<IComponentEvent> handler);
    }
}
