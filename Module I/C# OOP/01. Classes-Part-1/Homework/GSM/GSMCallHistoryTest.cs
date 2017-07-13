using System;
using System.Collections.Generic;

namespace GSM
{
    class GSMCallHistoryTest
    {
        public GSMCallHistoryTest()
        {
            GSM gsm1 = new GSM("3310", "Nokia", 60.90m, "Ivan", new Battery("R123DC1", 300m, BatteryType.Li_Ion), new Display(1.2m, 2));
            List<Call> calls = new List<Call>();
            calls.Add(new Call(DateTime.Now, DateTime.Today, "0898625332", 60));
            calls.Add(new Call(DateTime.Now, DateTime.Today, "0886273212", 52));
            calls.Add(new Call(DateTime.Now, DateTime.Today, "0886273212", 120));

            for (int i = 0; i < calls.Count; i++)
            {
                gsm1.AddCall(calls[i]);
            }

            gsm1.ShowHistory();

            Console.WriteLine(gsm1.CalculateTotalPrice(0.34m));
            int maxCallIndex = 0;
            for (int i = 0; i < calls.Count - 1; i++)
            {
                if (calls[i].Duration < calls[i + 1].Duration)
                {
                    maxCallIndex = i + 1;
                }
            }

            gsm1.DeleteCall(calls[maxCallIndex]);
            Console.WriteLine("After removing longest call:");
            Console.WriteLine(gsm1.CalculateTotalPrice(0.34m));
            Console.WriteLine();
            gsm1.ClearCallHistory();
            gsm1.ShowHistory();

        }
    }
}
