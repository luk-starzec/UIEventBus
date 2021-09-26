using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Catalog
{
    public class JsHelper : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public JsHelper(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/catalog/catalog.js").AsTask());
        }

        public async Task ScrollIntoView(string elementId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("scrollIntoView", elementId);

        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
