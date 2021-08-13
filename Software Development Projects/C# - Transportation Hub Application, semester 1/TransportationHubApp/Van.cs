using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    //2 constructors - 1 for make and model, another for when its missing
    [Serializable]
    public class Van : Vehicle
    {
        private double maxWeight;
        private double maxVolume;
        private int maxPassengers;
        
        public double MaxWeight
        {
            get
            {
                return this.maxWeight;
            }
            set
            {
                this.maxWeight = value;
            }
        }

        public double MaxVolume
        {
            get
            {
                return this.maxVolume;
            }
            set
            {
                this.maxVolume = value;
            }

        }
        public int MaxPassengers
        {
            get
            {
                return this.maxPassengers;
            }
            set
            {
                this.maxPassengers = value;
            }
        }

        public Van(int id, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume, int maxPassengers)
            :base(id, licensePlate, gasUsagePerKm, totalKm)
        {
            this.maxPassengers = maxPassengers;
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
        }


        public Van(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume, int maxPassengers)
            :base(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.maxPassengers = maxPassengers;
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;

        }

        public override string ToString()
        {
            return "Van: " +
                $"Max volume is: {this.MaxVolume}"
              + $"Max weight is: {this.MaxWeight}"
              + $"Max passengers are: {this.maxPassengers}" +
              base.ToString();

        }

    }
}
