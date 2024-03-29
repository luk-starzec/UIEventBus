﻿using Common;
using ComponentBus;
using System.Collections.Generic;
using System.Linq;

namespace Report
{
    public interface IEventParser
    {
        ReportLogModel EventToReportLog(IComponentEvent @event);
        string GetEventSource(IComponentEvent @event);
    }


    public class EventParser : IEventParser
    {
        List<string> eventSources = new()
        {
            "Catalog",
            "Warehouse",
            "Shop"
        };

        public ReportLogModel EventToReportLog(IComponentEvent @event)
        {
            if (@event is null)
                return null;

            var description = @event.GetType().Name;

            if (@event is ICancelableComponentEvent cancelable)
                description = $"{description} ({(cancelable.Canceled ? "canceled" : "confirmed")})";

            return new ReportLogModel(description);
        }

        public string GetEventSource(IComponentEvent @event)
        {
            if (@event is null)
                return null;

            var name = @event.GetType().Name;
            var source = eventSources.FirstOrDefault(r => name.ToLower().StartsWith(r.ToLower()));

            return source ?? "Other";
        }
    }

}
