using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Validation
{
    public class TodayOrFutureAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            DateTime date = (DateTime)value;

            return date >= DateTime.Today && date < DateTime.Today.AddDays(6);
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} nie mo¿e byæ dat¹ z przesz³oœci.";
        }
    }
}
