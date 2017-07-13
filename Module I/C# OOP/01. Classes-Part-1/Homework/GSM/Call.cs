using System;

namespace GSM
{
    class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private int duration;

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public Call(DateTime date, DateTime time, string dialedPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }
        public override string ToString()
        {
            return "On "+this.date.DayOfWeek + " at: " + this.date.Date.TimeOfDay + " you have dialed: " + this.dialedPhoneNumber + "; Call duration: " + this.duration+" seconds";
        }
    }
}
