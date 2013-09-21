using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    // Battery type enumeration
    public enum BatteryType
    {
        LiIon, NiMh, NiCd
    }

    public class Battery
    {
        // Declaring private fields
        // Considered that battery type is different from model, so i declared both type and model of the battery
        private BatteryType batteryTexture;
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        
        // Defining constructors
        public Battery(BatteryType texture, string model, int hoursIdle, int hoursTalk)
        {
            this.batteryTexture = texture;
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        //Defining properties
        public Battery(BatteryType texture)
        {
            this.batteryTexture = texture;
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public BatteryType BatteryTexture
        {
            get { return this.batteryTexture; }
            set { this.batteryTexture = value; }
        }

        public  string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || value.Length >= 0)
                {
                    this.model = value;
                }
                else
                    throw new ArgumentException();
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                    throw new ArgumentException();
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                    throw new ArgumentException();
            }
        }
    }


}
