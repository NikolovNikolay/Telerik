namespace RefactoreCook
{
    using System;
    using System.Linq;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            Carrot carrot = this.GetCarrot();           
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();            
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetableToBeCut)
        {
            vegetableToBeCut.IsCutToPeases = true;
        }

        private void Peel(Vegetable vegetableToBePeeles)
        {
            vegetableToBePeeles.HasRind = false;
        }
    }
}