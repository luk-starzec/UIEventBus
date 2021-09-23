using ComponentBus;

namespace Report
{
    public interface IEventParser
    {
        ReportLogModel EventToReportLog(IComponentEvent @event);
        string GetEventSource(IComponentEvent @event);
    }
}