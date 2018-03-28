using System.Globalization;
using System.Windows.Controls;

namespace Inlämningsuppgiftny
{
    class GenderValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string gender = value.ToString();

            if(gender == "Other")
                return new ValidationResult(false, "Sorry not SJW supported");
            else
                return new ValidationResult(true, "");
        }
    }
}
