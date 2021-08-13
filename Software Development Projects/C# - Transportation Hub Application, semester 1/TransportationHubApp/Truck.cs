using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    [Serializable]
    public class Truck : Freighter
    {
        //2 Constructors - 1 for trucks with make and model, another without it
        public Truck(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume)
       : base(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume)
        {
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }

        public Truck(int id, string licensePlate, double gasUsagePerKm, double totalKm, double maxWeight, double maxVolume)
      : base(id, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume)
        {
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }

        public override string ToString()
        {
            return "Truck: " +
               $" Max weight is: {this.MaxWeight}"
            + $", Max volume is: {this.MaxVolume} ,"
            + base.ToString();
    
        }


    }
}
