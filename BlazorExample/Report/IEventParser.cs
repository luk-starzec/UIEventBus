using ComponentBus;

namespace BlazorExample.Report
{
    public interface IEventParser
    {
        ReportModel EventToReport(IComponentEvent @event);
    }
}