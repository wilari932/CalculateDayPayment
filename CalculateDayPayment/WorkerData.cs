using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDayPayment
{

    public class WorkerData
    {
        public double PricePerExtraHours { get; set; } = 5000;
        public double PricePerWorkingSift { get; set; } = 40000;
        public double PrecentageExtraOnHolyday { get; set; } = 0.10;
        public double PrecentageExtraNight { get; set; } = 0.15;
        public double ExtraHolydayAndNight { get; set; } = 0.20;
        public List<WorkingSift> workingSifts { get; set; } = new List<WorkingSift>();

    }
}
