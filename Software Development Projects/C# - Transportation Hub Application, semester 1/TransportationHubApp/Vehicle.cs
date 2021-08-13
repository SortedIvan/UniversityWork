using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    //Main class - inheritants: PassengerTransport + Freighter classes
    [Serializable]
    public abstract class Vehicle
    {
        private string makeAndModel; //optional, user input
        private string licensePlate; //user input
        private double gasUsagePerKm;
        private double pricePerKm;
        private double consumedFuel; //Calculates the total consumption of fuel
        private double totalKm;
        private int id;


        public Vehicle(int id, string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm)
        {
            this.id = id;
            this.makeAndModel = makeAndModel;
            this.licensePlate = licensePlate;
            this.gasUsagePerKm = gasUsagePerKm;
            this.pricePerKm = 10 * gasUsagePerKm;
            this.consumedFuel = totalKm * gasUsagePerKm;
            this.totalKm = totalKm;
        }
        public Vehicle(int id, string licensePlate, double gasUsagePerKm, double totalKm)
        {
            this.id = id;
            this.licensePlate = licensePlate;
            this.gasUsagePerKm = gasUsagePerKm;
            this.pricePerKm = 10 * gasUsagePerKm;
            this.consumedFuel = totalKm * gasUsagePerKm;
            this.totalKm = totalKm;
        }
        public string MakeAndModel
        {
            get
            {
                return this.makeAndModel;
            }
            set
            {
                this.makeAndModel = value;
            }
        }
        public double GasUsagePerKm
        {
            get
            {
                return this.gasUsagePerKm;
            }
            set
            {
                this.gasUsagePerKm = value;
            }
                
    
        }
        //public int MaxPeople
        //{
        //    get
        //    {
        //        return this.MaxPeople;
        //    }
        //}

        public double PricePerKm
        {
            get
            {
                return this.pricePerKm;
            }
        }
        public double TotalKm
        {
            get
            {
                return this.totalKm;
            }
            set
            {
               this.totalKm = value; //
            }
        }
        public string LicensePlate
        {
            get
            {
                return this.licensePlate;
            }
            set
            {
                this.licensePlate = value; //
            }
        }

   

        public override string ToString()
        {
            return 
            $"Model: {this.makeAndModel}, Licenseplate: {this.licensePlate}, Gas usage: {this.gasUsagePerKm}, Total km: {this.totalKm}";

        }



    }
}
