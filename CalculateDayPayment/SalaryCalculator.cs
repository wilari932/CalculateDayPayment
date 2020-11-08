using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateDayPayment
{
    public class SalaryCalculator
    {
     
        public double CalculateSalaryByData(WorkerData data)
        {
            double result = 0;
            foreach (var dt in data.workingSifts)
            {
                double extra = 0;
                var pricePerHour = data.PricePerWorkingSift / 8;
                if (dt.ExtraHoursDay > 0) 
                {
                    extra =  (dt.IsHolyDay) ? data.PrecentageExtraOnHolyday : 0;
                    result += (dt.ExtraHoursDay * data.PricePerExtraHours) + (dt.ExtraHoursDay * data.PricePerExtraHours * extra);
                }
                if(dt.ExtraHoursNight > 0)
                {
                    extra = (dt.IsHolyDay) ? data.ExtraHolydayAndNight : data.PrecentageExtraNight;
                    result += (dt.ExtraHoursNight * data.PricePerExtraHours) +(dt.ExtraHoursNight * data.PricePerExtraHours * extra);
                }
                if (dt.NightHours > 0)
                {
                    extra = (dt.IsHolyDay) ? data.ExtraHolydayAndNight : data.PrecentageExtraNight;
                    result += (dt.NightHours * pricePerHour) + (dt.NightHours * pricePerHour * extra);
                }
                extra = (dt.IsHolyDay) ? data.PrecentageExtraOnHolyday : 0;
               
                result += (dt.DayHours * pricePerHour) + (dt.DayHours * pricePerHour * extra);

               
            }
            return result;
        }
        public List<PaymentResult> CalculateSalaries(params Person[] people)
        {
            var list = new List<PaymentResult>();
            foreach (var person in people)
            {
               var result =  CalculateSalaryByData(person.WorkerData);
                list.Add(new PaymentResult
                {
                    Person = person,
                    Salary = result
                });
            }
            return list;
        }
    }
}
