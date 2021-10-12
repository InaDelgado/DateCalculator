using DateCalculator.Models;
using DateCalculator.Models.Factories;
using DateCalculator.Utils.Exceptions;
using DateCalculator.Utils.Extensions;
using DateCalculator.Utils.Validators;
using System;

namespace DateCalculator.System
{
    public class DateManager
    {
        private string _inputDate { get; }
        private string _operation { get; }
        private long _amount;
        private Date _date { get; set; }
        private IOperationFactory _operationFactory = null;

        public DateManager(string date, string operation, string amount)
        {
            _inputDate = date;
            _operation = operation;
            long.TryParse(amount, out _amount);
        }

        public void ToManage()
        {
            try
            {
                PopulateDate();

                switch (_operation.ToLower())
                {
                    case "increase":
                        _operationFactory = new OperationIncreaseFactory(_date, _amount);
                        break;
                    case "decrease":
                        _operationFactory = new OperationDecreaseFactory(_date, _amount);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw new InvalidInputOperationException();
            }
        }

        public Operation ExecuteFactory()
        => _operationFactory.FindOperation();

        public void ValidateDateTime()
        {
            try
            {
                var validator = new InputValidator(_operation, _inputDate, _amount.ToString());

                if(validator.InputIsValid())
                    PopulateDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PopulateDate()
        {
            _date = new Date
            {
                Day = _inputDate.GetDay(),
                Month = _inputDate.GetMonth(),
                Year = _inputDate.GetYear(),
                Hour = _inputDate.GetHour(),
                Minute = _inputDate.GetMinute()
            };
        }
    }
}