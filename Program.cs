using System;
using System.Collections.Generic;

namespace CalculateDayPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SalaryCalculator();

          var result =  calculator.CalculateSalaries(
                new Person
                    {
                        Name = "Pedro",
                        WorkerData = new WorkerData
                        {
                            workingSifts = new List<WorkingSift>
                            {
                                new WorkingSift
                                {
                                    DayHours = 8,
                                    ExtraHoursDay = 1,
                                    IsHolyDay = true
                                },

                                new WorkingSift
                                {
                                    DayHours = 4,
                                    ExtraHoursDay = 0,
                                    ExtraHoursNight = 1,
                                    NightHours = 5,
                                    IsHolyDay = true
                                },
                            }
                        }

                    },
                 new Person
                 {
                     Name = "Roberto",
                     WorkerData = new WorkerData
                     {
                         workingSifts = new List<WorkingSift>
                            {
                                new WorkingSift
                                {
                                    DayHours = 8,
                                    ExtraHoursDay = 1,
                                    IsHolyDay = true
                                },
                            }
                     }

                 }

                );
            foreach(var item in result)
            {
                Console.WriteLine("{0}", item.Person.Name);
                Console.WriteLine("Su salario sera: {0}", item.Salary);

            }
            Console.ReadKey();
        
        }
    }
}
