using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    [Serializable]
    //Passenger transport - 1 has make and model, the other one does not
    public abstract class PassengerTransport : Vehicle
    {
        public PassengerTransport(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm)
            :base(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.MaxPassengers = maxPassengers;
            
        }

        public PassengerTransport(int id, string licenseplate, double gasUsagePerKm, double totalKm)
            :base(id, licenseplate, gasUsagePerKm, totalKm)
        {

        }

        private int maxPassengers;

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

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
