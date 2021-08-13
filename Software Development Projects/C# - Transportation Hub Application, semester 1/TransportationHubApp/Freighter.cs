using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    //Inherits from vehicle: has 2 constructors - 1 with make and model, the other one without it
    [Serializable]
    public abstract class Freighter : Vehicle
    {
        private double maxWeight;
        private double maxVolume;

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


      public Freighter(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume)
            :base(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }
        public Freighter(int id, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume)
           : base(id, licensePlate, gasUsagePerKm, totalKm)
        {
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }


    }
}
