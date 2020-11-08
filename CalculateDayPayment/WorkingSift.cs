using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDayPayment
{
    public class WorkingSift
    {
        public WorkingSift()
        {
        }
        private double _DayHours;
        public double DayHours
        {
            get { return _DayHours; }
            set
            {
                if (value > 8 && value >= 0)
                {

                    throw new OverflowException("The day Hours cannot be grather than 8 and grather or equals 0");

                }
                _DayHours = value;
            }
        }

        public double NightHours { get; set; }

        public double ExtraHoursDay { get; set; }

        public double ExtraHoursNight { get; set; }

        public bool IsHolyDay { get; set; }

    }
}
