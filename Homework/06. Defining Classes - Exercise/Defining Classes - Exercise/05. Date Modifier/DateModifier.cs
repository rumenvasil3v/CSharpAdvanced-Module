using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public void CalculateDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            var currentFirstDate = DateTime.Parse(firstDate);
            var currentSecondDate = DateTime.Parse(secondDate);

            TimeSpan differenceOfDates = currentSecondDate.Subtract(currentFirstDate);

            Console.WriteLine(Math.Abs(differenceOfDates.Days));
        }
    }
}
