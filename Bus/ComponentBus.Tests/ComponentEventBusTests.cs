using System.Threading.Tasks;
using Xunit;

namespace ComponentBus.Tests
{
    public class ComponentEventBusTests
    {
        [Fact]
        public async Task SubscribedHandlerCalledWhenPublishedEvent()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();

            sut.Subscribe<TestEvent>(component.TestEventHandler);
            await sut.Publish(new TestEvent());

            Assert.Equal(1, component.Counter);
        }

        [Fact]
        public async Task SubscribedAsyncHandlerCalledWhenPublishedEvent()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();

            sut.Subscribe<TestEvent>(component.TestEventAsyncHandler);
            await sut.Publish(new TestEvent());

            Assert.Equal(1, component.Counter);
        }

        [Fact]
        public async Task SubscribedHandlerNotCalledWhenPublishedDifferentEvent()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();

            sut.Subscribe<TestEvent>(component.TestEventHandler);
            await sut.Publish(new DifferentTestEvent());

            Assert.Equal(0, component.Counter);
        }

        [Fact]
        public async Task UnsubscribedHandlerNotCalledWhenPublishedEvent()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();

            sut.Subscribe<TestEvent>(component.TestEventHandler);
            sut.Unsubscribe(component.TestEventHandler);
            await sut.Publish(new TestEvent());

            Assert.Equal(0, component.Counter);
        }

        [Fact]
        public async Task UnsubscribedAsyncHandlerNotCalledWhenPublishedEvent()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();

            sut.Subscribe<TestEvent>(component.TestEventAsyncHandler);
            sut.Unsubscribe(component.TestEventAsyncHandler);
            await sut.Publish(new TestEvent());

            Assert.Equal(0, component.Counter);
        }

        [Fact]
        public async Task HandlerGetsEventPayload()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();
            var expected = "test";

            sut.Subscribe<TestEvent>(component.TestEventHandler);
            await sut.Publish(new TestEvent(expected));

            Assert.Equal(expected, component.EventPayload);
        }

        [Fact]
        public async Task AsyncHandlerGetsEventPayload()
        {
            var sut = new ComponentEventBus();
            var component = new TestComponent();
            var expected = "test";

            sut.Subscribe<TestEvent>(component.TestEventAsyncHandler);
            await sut.Publish(new TestEvent(expected));

            Assert.Equal(expected, component.EventPayload);
        }
    }

    internal record TestEvent(string Payload = null) : IComponentEvent;
    internal record DifferentTestEvent() : IComponentEvent;

    internal class TestComponent
    {
        public int Counter { get; set; }
        public string EventPayload { get; set; }

        public void TestEventHandler(IComponentEvent @event)
        {
            Counter++;

            var msg = @event as TestEvent;
            EventPayload = msg?.Payload;
        }

        public async Task TestEventAsyncHandler(IComponentEvent @event)
        {
            Counter++;

            var msg = @event as TestEvent;
            EventPayload = msg?.Payload;

            await Task.CompletedTask;
        }
    }

}
