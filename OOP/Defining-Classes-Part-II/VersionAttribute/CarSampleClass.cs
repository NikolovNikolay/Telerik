using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [VersionAttribute(2.11)]
    class CarSampleClass
    {
        private SampleCarsEnumColor color;
        private SampleCarsEnumMaker maker;
        private int horsePower;

        public CarSampleClass(SampleCarsEnumMaker maker, SampleCarsEnumColor color, int horsePower)
        {
            this.maker = maker;
            this.color = color;
            this.horsePower = horsePower;
        }

        public SampleCarsEnumColor Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public SampleCarsEnumMaker Maker
        {
            get
            {
                return this.maker;
            }

            set
            {
                this.maker = value;
            }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }
    }
}
