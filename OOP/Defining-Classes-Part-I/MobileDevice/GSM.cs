using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MobileDevice
{
    public class GSM
    {
        //Defining private field members
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        // Static field iPhone
        static private GSM iPhone4S = new GSM("4s", "Apple", 1000);

        // Defining some constructors
        public GSM(string model, string manufacturer, int price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer) 
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM (string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            
        }

        // Declare properties
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                else
                    this.model = value;
            }       
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                else
                    this.manufacturer = value;
            }
        }

        public int? Price
        {
            get { return this.price; }
            set
            {
                if (value == null || value >= 0)
                    this.price = value;
                else
                    throw new ArgumentException();
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Owner not in correct format!");
                else
                    this.owner = value;
            }
        }
                // Call history property that holds the call objects
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        // Property of the static field iPhone
        public static GSM iPhone
        {
            get { return iPhone4S; }
        }

        // Methods that handle calls in the call history - Add/Remove(via duration ^ number), Clear
        public void AddCallToHistory(string number, int duration)
        {
             Call newCall = new Call(DateTime.Now,number,duration);
             callHistory.Add(newCall);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public void RemoveCallsFromHistoryViaNumber(string number)
        {
            for (int i = callHistory.Count-1; i >= 0; i--)
            {
                if(callHistory[i].PhoneNumber == number)
                {
                    callHistory.RemoveAt(i);
                }
            }
        }

        public void RemoveCallsFromHistoryViaDuration(int duration)
        {
            for (int i = callHistory.Count - 1; i >= 0; i--)
            {
                if (callHistory[i].Duration == duration)
                {
                    callHistory.RemoveAt(i);
                }
            }
        }

        // Method that calculates the total price of the calls in the call history
        public double CalculateTotalPriceOfCalls(double pricePerMinute)
        {
            double totalPrice = 0;
            int totalDuration = 0;

            foreach (var call in callHistory)
            {
                totalDuration += call.Duration;
            }
            totalPrice = ((totalDuration / 60) * pricePerMinute);
            return totalPrice;
        }


        // Overriding ToString() method, so it can display mobile device's info. There are some check-ups in the method, so that NllRefferenceException
        // can't be thrown, if some unnecessary fields aren't used in the constructor.
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("..:: Mobile device info ::..");
            sb.AppendLine("Manufacturer: "+this.manufacturer);
            sb.AppendLine("Model: "+this.model);
            if(this.price != null)
                sb.AppendLine("Price: " + this.price);
            if(this.owner != null)
                sb.AppendLine("Owner: " + this.owner);
            if (this.battery != null)
            {
                sb.AppendLine("Battery texture: " + this.battery.BatteryTexture);
                if (this.battery.Model != null)
                    sb.AppendLine("Battery model: " + this.battery.Model);
                if (this.battery.HoursIdle != null)
                    sb.AppendLine("Battery strength in idle hours: " + this.battery.HoursIdle);
                if (this.battery.HoursTalk != null)
                    sb.AppendLine("Battery strength in talk hours: " + this.battery.HoursTalk);
            }
            if (this.display != null)
            {
                if (this.display.Size != null) 
                    sb.AppendLine("Display size: " + this.display.Size);
                if (this.display.NumberOfColors != null)
                    sb.AppendLine("Display colors: " + this.display.NumberOfColors);
            }

            return sb.ToString();
        }
    }
}
