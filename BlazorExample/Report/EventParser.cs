using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Report
{
    public class EventParser : IEventParser
    {
        public ReportModel EventToReport(IComponentEvent @event)
        {
            if (@event is null)
                return null;

            var description = @event.GetType().Name;

            if (@event is ICancelableComponentEvent cancelable)
                description = $"{description} ({(cancelable.Canceled ? "canceled" : "confirmed")})";

            return new ReportModel(description);
        }
    }
}
