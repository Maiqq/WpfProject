using System;
using System.Globalization;
using System.Windows.Controls;

namespace Inlämningsuppgiftny
{
    class DateValidator : ValidationRule

    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            try
            {
                DateTime dates = DateTime.Parse(value.ToString());
                DateTime datesnow = DateTime.Now.Date;
                int result = DateTime.Compare(dates, datesnow);

                if (result >= 0)
                    return new ValidationResult(true, "");
                else
                    return new ValidationResult(false, "Must be a future date!");
            }
            catch
            {
                return new ValidationResult(false, "Date has to be in the form of d.m.y");
            }
    }
    }
}
