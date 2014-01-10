namespace RefactoreCook
{
    using System;
    using System.Linq;

    public class Vegetable
    {
        private bool hasRind;
        private bool isCutToPeases;

        public Vegetable()
        {
            this.HasRind = true;
            this.IsCutToPeases = false;
        }

        public bool HasRind
        {
            get
            {
                return this.hasRind;
            }

            set
            {
                this.hasRind = value;
            }
        }

        public bool IsCutToPeases
        {
            get
            {
                return this.isCutToPeases;
            }

            set
            {
                this.isCutToPeases = value;
            }
        }
    }
}
