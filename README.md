# Component Event Bus

## Basic config
Add ComponentEventBus to project DI

## Create event
Event can be any class implementing interface IComponentEvent. This interface is only used as marker. 

If you want to pass any payload in event, define additional fields in class.

### For example:
Event with Id as payload

    public class TestEvent : IComponentEvent
    {
        public int Id { get; set; }
    }

Event with Id and Text

    public record TestEvent(int Id, string Text) : IComponentEvent;

## Publishing
Inject ComponentEventBus into component

    @inject ComponentEventBus bus

Call Publish method

    await bus.Publish(new TestEvent() { Id = Id });


## Subscribing
Inject ComponentEventBus into component

    @inject ComponentEventBus bus

Create handler method

    void TestEventHandler(IComponentEvent @event)
    {
        var msg = @event as TestEvent;
        ...
    }

or

    async Task TestEventHandler(IComponentEvent @event)
    {
        var msg = @event as TestEvent;
        ...
    }
Subscribe in OnInitialized method

    protected override void OnInitialized()
    {
        bus.Subscribe<TestEvent>(TestEventHandler);
    }

Unsubscribe on dispose

    @implements IDisposable
    ...
    void IDisposable.Dispose()
    {
        bus.Unsubscribe(TestHandler);
    }

## Simple example

    // event
    public record SimpleEvent(int Id, string Text) : IComponentEvent;
     

    // publishing component
    @inject ComponentEventBus bus

    <div>
        <span>#@Id</span>
        <input @bind-value="text" />
        <button @onclick="OnClick">Click me</button>
    </div>

    @code {
        [Parameter] public int Id { get; set; }

        string text = "Hello";

        async Task OnClick() => await bus.Publish(new SimpleEvent(Id, text));
    }


    // receiving component
    @inject ComponentEventBus bus
    @implements IDisposable

    <ul>
        @foreach (var item in items)
        {
            <li>
                @item
            </li>
        }
    </ul>

    @code {
        List<string> items = new List<string>();

        protected override void OnInitialized()
        {
            bus.Subscribe<SimpleEvent>(SimpleEventHandler);
        }
        void IDisposable.Dispose()
        {
            bus.Unsubscribe(SimpleEventHandler);
        }

        void SimpleEventHandler(IComponentEvent @event)
        {
            var msg = @event as SimpleEvent;
            items.Add($"{DateTime.Now} - Component #{msg.Id} says: {msg.Text}");
            StateHasChanged();
        }

    }
