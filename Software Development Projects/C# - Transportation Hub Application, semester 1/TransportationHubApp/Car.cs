using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    [Serializable]
    public class Car : PassengerTransport
    {
        //2 Constructors, 1 for cars with make and model, the other without it
        public Car(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, int maxPassengers)
            :base(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.MaxPassengers = maxPassengers;
        }
        public Car(int id, string licensePlate, double gasUsagePerKm, double totalKm, int maxPassengers)
            :base(id, licensePlate, gasUsagePerKm, totalKm)
        {
            this.MaxPassengers = maxPassengers;
        }


        public override string ToString()
        {
            return
               $"Car, Max passengers are: {this.MaxPassengers}" +
             base.ToString();
               
        }

    }
}
