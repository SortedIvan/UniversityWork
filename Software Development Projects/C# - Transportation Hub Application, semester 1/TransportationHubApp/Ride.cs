using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    [Serializable]
    public class Ride
    {
        private Vehicle vehicle;
        private double personAmount; // OPTIONAL
        private double cargoVolume; // OPTIONAL
        private double cargoWeight; //OPTIONAL
        private double priceOfRide;
        private double startingPrice; //OPTIONAL
        private double expectedKm;
        private DateTime startingTime;
        private DateTime endTime;

        public Vehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
        }
        
        public Ride(Vehicle vehicle, int personAmount, double startingPrice, double expectedKm, DateTime startingTime)
        {
            //this.priceOfRide = (vehicle.PricePerKm * expectedKm) + startingPrice;
            this.startingPrice = startingPrice;
            this.startingTime = startingTime;
            //this.endTime = endTime;
            this.personAmount = personAmount;
            this.expectedKm = expectedKm;
        }
        public Ride(Vehicle vehicle, double cargoVolume, double cargoWeight, double startingPrice, double expectedKm, DateTime startingTime)
        {
            this.cargoVolume = cargoVolume;
            this.cargoWeight = cargoWeight;
        }

        public double EndRide(int expectedKm)
        {
            return 0;
        }
        
        public string GetRideInformation()
        {
            return $"Vehicle:" +
                $"{this.vehicle.ToString()}";
        }
        public override string ToString()
        {
            
            return $"Booked: Cargo volume: {this.cargoVolume}, Max weight: {this.cargoWeight}, Max passengers: {this.personAmount}";
                
        }


    }
}
