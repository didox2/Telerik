using System;

namespace GSM
{
    class Battery
    {
        private string model;
        private decimal? hoursTalk;
        private BatteryType? batteryType;

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }
        public decimal? HoursTalk
        {
            get { return this.hoursTalk; }
            private set { this.hoursTalk = value; }
        }
        public BatteryType? BatteryType
        {
            get { return this.batteryType; }
            private set { this.batteryType = value; }
        }

        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(string model, decimal? hoursTalk = null, BatteryType? batteryType = null)
            : this(model)
        {
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public override string ToString()
        {
            return "Battery (Model: " + this.Model + "; Hours talk: " + this.HoursTalk + "; Battery type: " + this.BatteryType + ")";
        }
    }
}
