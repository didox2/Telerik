using System;

namespace GSM
{
    public class GSMTest
    {
        public static void Main()
        {
            GSM[] array = new GSM[4];
            GSM gsm1 = new GSM("3310", "Nokia", 60.90m, "Ivan", new Battery("R123DC1", 300m, BatteryType.Li_Ion), new Display(1.2m, 2));
            GSM gsm2 = new GSM("Galaxy S8", "Samsung", 60.90m, "Ditmar", new Battery("22315", 500m, BatteryType.NiCd), new Display(5.5m, 16000000));
            GSM gsm3 = new GSM("10", "HTC", 60.90m, "Dragan", new Battery("0123DC", 550m, BatteryType.NiMH), new Display(5.4m, 16000000));
            GSM gsm4 = new GSM("3310", "Nokia");
            array[0] = gsm1;
            array[1] = gsm2;
            array[2] = gsm3;
            array[3] = gsm4;


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();
            Console.WriteLine("Call history: ");

            GSMCallHistoryTest callhistory = new GSMCallHistoryTest();

        }
    }
}
