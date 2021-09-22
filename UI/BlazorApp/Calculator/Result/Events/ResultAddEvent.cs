using ComponentBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Result.Events
{
    public record ResultAddEvent : IComponentEvent
    {
        public Guid Id { get; init; }
        public int OperationId { get; init; }
        public string Operator { get; init; }
        public IEnumerable<ParameterModel> Parameters { get; init; }
        public decimal? Result { get; set; }

        public ResultAddEvent()
        { }

        public ResultAddEvent(ResultModel model)
        {
            Id = model.Id;
            OperationId = (int)model.Operation;
            Operator = model.OperationText;
            Parameters = model.Parameters;
            Result = model.Result;
        }
    }

}
