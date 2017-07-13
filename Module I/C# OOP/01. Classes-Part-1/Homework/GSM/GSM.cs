using System;
using System.Collections.Generic;

namespace GSM
{
    class GSM
    {
        private static GSM iPhone4S;
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public static GSM IPhone4S
        {
            get
            {
                iPhone4S = new GSM("Iphone 4S", "Apple", 399.99m, "Pesho", new Battery("GM042D", 250, BatteryType.Li_Ion), new Display(4.5m, 16000000));
                return iPhone4S;
            }
        }
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be null or empty!");
                }

                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufacturer cannot be null or empty!");
                }

                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid GSM price data. You should enter positive number!");
                }

                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid GSM owner data");
                }

                this.owner = value;
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            private set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    this.callHistory.Add(value[i]);
                }
            }

        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public void ShowHistory()
        {
            if (CallHistory.Count != 0)
            {
                foreach (var call in CallHistory)
                {
                    Console.WriteLine(call);
                }
            }
            else
            {
                Console.WriteLine("Call history is empty");
            }
        }
        public string CalculateTotalPrice(decimal pricePerMinet)
        {
            decimal counter = 0;
            decimal price = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                counter += callHistory[i].Duration;
            }
            price = (counter / 60) * pricePerMinet;
            return string.Format("All calls total price = {0:F2} lv", price);
        }
        public override string ToString()
        {
            return "GMS (Model: " + this.Model + "; Manufacturer: " + this.Manufacturer + "; Price: " + this.Price + "; Owner: " + this.Owner + "; " + this.Battery + "; " + this.Display + ";";
        }
    }
}
