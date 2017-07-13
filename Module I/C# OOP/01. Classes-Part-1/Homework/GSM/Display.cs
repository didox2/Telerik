using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Display
    {
        private decimal size;
        private int numberOfColors;

        public Display(decimal size)
        {
            this.Size = size;
        }
        public Display(decimal size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public decimal Size 
        { 
            get
            {
                return this.size;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The size cannot be less than 0!");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("The number of colors cannot be less than 2!");
                }
                this.numberOfColors = value;
            }
        }
        public override string ToString()
        {
            return "Display (Size: " + this.Size + "; Number of colors: " + this.NumberOfColors + ")";
        }
    }
}
