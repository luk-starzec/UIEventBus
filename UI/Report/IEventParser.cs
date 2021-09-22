using ComponentBus;

namespace Report
{
    public interface IEventParser
    {
        ReportModel EventToReport(IComponentEvent @event);
    }
}