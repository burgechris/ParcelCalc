using System;

namespace Parcels.Models
{
    public class Parcel
    {
        public double[] Dimensions {get; set;}
        public double Weight {get; set;}

        public Parcel(double[] dimensions, double weight)
        {
            Dimensions = dimensions;
            Weight = weight;
        }

        public double Volume()
        {
            return Math.Round(Dimensions[0] * Dimensions[1] * Dimensions[2], 2);
        }

        public double CostToShip()
        {
            return Volume() * Weight;
        }

        public double[] GetValues()
        {
            return new double[] {Dimensions[0], Dimensions[1], Dimensions[2], Weight, Volume(), CostToShip() };
        }
    }
}