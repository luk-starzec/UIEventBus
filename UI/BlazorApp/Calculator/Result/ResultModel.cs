using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Calculator.Result
{
    public class ResultModel
    {
        public Guid Id { get; set; }
        public OperationEnum Operation { get; set; }
        public List<ParameterModel> Parameters { get; set; }

        public string OperationText => Operation.GetDescription();

        public decimal? Result => GetResult();


        private decimal? GetResult()
        {
            if (Parameters?.Any() != true)
                return null;

            return Operation switch
            {
                OperationEnum.Add => Parameters.Sum(r => r.Value),
                OperationEnum.Subtract => Parameters.Select(r => r.Value).Aggregate((a, b) => a - b),
                OperationEnum.Multiply => Parameters.Select(r => r.Value).Aggregate((a, b) => a * b),
                OperationEnum.Divide => Parameters.Skip(1).All(r => r.Value != 0) ? Parameters.Select(r => r.Value).Aggregate((a, b) => a / b) : null,
                _ => null,
            };
        }
    }


    public enum OperationEnum
    {
        [Description("+")]
        Add,
        [Description("-")]
        Subtract,
        [Description("*")]
        Multiply,
        [Description("/")]
        Divide
    }

    public class ParameterModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }

}