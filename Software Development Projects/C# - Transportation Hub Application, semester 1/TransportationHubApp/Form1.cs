using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TransportationHubApp
{
    //Ivan Georgiev Ovcharov
    [Serializable]
    public partial class TransportationHub : Form
    {
        private List<Ride> allRides; // All rides in progress
        private List<Ride> completedRides; // All of the completed rides
        private List<Vehicle> availableVehicles;
        private List<Vehicle> vehicleOnRide; // Vehicles currently not available


        public TransportationHub()
        {
            if(ReadState2() == null) { 
            this.allRides = new List<Ride>();
            }
            else
            {
                this.allRides = ReadState2();
            }
            this.completedRides = new List<Ride>();
            if(ReadState1() == null) { 
            this.availableVehicles = new List<Vehicle>();
            }
            else
            {
                this.availableVehicles = ReadState1();
             }
            this.vehicleOnRide = new List<Vehicle>();


            CreateOpenState1(); //Read
            InitializeComponent();

        }





        //Create a freighter ride
        public void AddRide(Freighter freighter, int personAmount, double startingPrice, double expectedKm, DateTime startingTime)
        {
            Ride ride = new Ride(freighter, personAmount, startingPrice, expectedKm, startingTime);/*freighter, */;

        }
        //Create a passenger transport ride
        public void AddRide(PassengerTransport passengerTransport, double startingPrice, double expectedKm, DateTime startingTime, double maxWeight, double maxVolume)
        {
            Ride ride = new Ride(passengerTransport, maxVolume, maxWeight, startingPrice, expectedKm, startingTime);/*passengerTransport, */;
        }

        public void StartRide(Ride ride) //Begins a ride with a vehicle
        {
            vehicleOnRide.Add(ride.Vehicle);
        }



        public void EndRide(Ride ride) //Terminates a ride and returns the vehicle in available list
        {
            completedRides.Add(ride);
            availableVehicles.Add(ride.Vehicle);
            vehicleOnRide.Remove(ride.Vehicle);
        }

        public void AddVehicle(Vehicle vehicle) //Adds a vehicle to the list
        {
            availableVehicles.Add(vehicle);
        }
        public void AddRide(Ride ride)
        {
            allRides.Add(ride);
        }
        public void ViewCompletedRides() //Lists all of the completed rides
        {
            foreach (Ride r in completedRides)
            {
                lbxVehicleResult.Items.Add(r.ToString());
            }
        }
        public void ViewRidesInProgress() // Lists vehicles not available for rides
        {
            foreach (Vehicle v in vehicleOnRide)
            {
                lbxVehicleResult.Items.Add(v.ToString());
            }
        }

        public void ViewAvailableVehicles() // Lists all of the available vehicles
        {
            lbxVehicleResult.Items.Clear();
            foreach (Vehicle v in availableVehicles)
            {
                lbxVehicleResult.Items.Add(v.ToString());
            }
        }

        public void ViewAllRides() //Show all of the current vehicles on rides
        {
            foreach (Ride r in allRides)
            {
                lbxBookedRide.Items.Add(r.ToString());
            }
        }





        //Add a vehicle to the list + listbox (depending on the selected index)
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {

            if (cbxVehicleType.SelectedIndex > -1) {
                if (cbxVehicleType.SelectedIndex == 0)
                {

                    AddCar();
                    ViewAvailableVehicles();




                }
                else if (cbxVehicleType.SelectedIndex == 1)
                {

                    AddTruck();
                    ViewAvailableVehicles();
                }
                else if (cbxVehicleType.SelectedIndex == 2)
                {

                    AddVan();
                    ViewAvailableVehicles();

                }
            }
            else
            {
                MessageBox.Show("Select a vehicle type first!");
            }






        }
        //Creates a car object and adds it to the list
        private string AddCar()
        {
            string makeAndModel = Convert.ToString(tbxMakeModel.Text);
            string licensePlate = Convert.ToString(tbxLicensePlate.Text);
            if (string.IsNullOrEmpty(licensePlate))
            {
                return "Please enter license plate!";
            }
            try
            {
                double gasUsagePerKm = Convert.ToDouble(tbxGasUsagePerKm.Text);
                double totalKm = Convert.ToDouble(tbxTotalKm.Text);
                int maxPassengers = Convert.ToInt32(tbxMaxPeople.Text);
                int id = 0;

                if (string.IsNullOrEmpty(makeAndModel))
                {
                    Car car = new Car(id, licensePlate, gasUsagePerKm, totalKm, maxPassengers);
                    AddVehicle((Vehicle)car);

                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }
                else
                {
                    Car car = new Car(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm, maxPassengers);
                    AddVehicle((Vehicle)car);
                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }


            }
            catch (System.FormatException ex)
            {


                //MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show("Please add valid values");


            }

            return "Sucess!";

        }
        //Creates a truck object and adds it to the list
        private string AddTruck()
        {
            string makeAndModel = Convert.ToString(tbxMakeModel.Text);
            string licensePlate = Convert.ToString(tbxLicensePlate.Text);
            if (string.IsNullOrEmpty(licensePlate))
            {
                return "Please enter license plate!";
            }
            try
            {
                double gasUsagePerKm = Convert.ToDouble(tbxGasUsagePerKm.Text);
                double totalKm = Convert.ToDouble(tbxTotalKm.Text);
                double maxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                double maxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                int id = 0;

                if (string.IsNullOrEmpty(makeAndModel))
                {
                    Truck truck = new Truck(id, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume);
                    AddVehicle((Vehicle)truck);
                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }

                else
                {
                    Truck truck = new Truck(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume);
                    AddVehicle((Vehicle)truck);
                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }


            }
            catch (System.FormatException ex)
            {

                //MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show("Please add valid values");

            }

            return "Sucess!";
        }
        //Creates a van object and adds it to the list
        private string AddVan()
        {
            string makeAndModel = Convert.ToString(tbxMakeModel.Text);
            string licensePlate = Convert.ToString(tbxLicensePlate.Text);

            if (string.IsNullOrEmpty(licensePlate))
            {
                return "Please enter license plate!";
            }
            try
            {
                double gasUsagePerKm = Convert.ToDouble(tbxGasUsagePerKm.Text);
                double totalKm = Convert.ToDouble(tbxTotalKm.Text);
                double maxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                double maxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                int maxPassengers = Convert.ToInt32(tbxMaxPeople.Text);
                int id = 0;

                if (string.IsNullOrEmpty(makeAndModel))
                {
                    Van van = new Van(id, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume, maxPassengers);
                    AddVehicle((Vehicle)van);
                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }

                else
                {
                    Van van = new Van(id, makeAndModel, licensePlate, gasUsagePerKm, totalKm, maxWeight, maxVolume, maxPassengers);
                    AddVehicle((Vehicle)van);
                    tbxPricePerKm.Text = "$" + (gasUsagePerKm * 10).ToString();
                }


            }
            catch (System.FormatException ex)
            {

                //MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show("Please add valid values");

            }

            return "Sucess!";
        }
        //Clears all of the text boxes for convenience
        private void btnClearTbx_Click(object sender, EventArgs e)
        {
            tbxMakeModel.Clear();
            tbxLicensePlate.Clear();
            tbxGasUsagePerKm.Clear();
            tbxPricePerKm.Clear();
            tbxTotalKm.Clear();
            tbxMaxPeople.Clear();
            tbxMaxVolume.Clear();
            tbxMaxWeight.Clear();
        }
        public double CalculatePricePerKm(double gasUsage) //Calculating the price per km
        {
            gasUsage = Convert.ToDouble(tbxGasUsagePerKm.Text);
            return gasUsage * 10;
        }

        //Fills in the information in the textboxes ( for editing purposes )
        private void lbxVehicleResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            //0,1,2,3,4,5...
            // fills in the information but gives error
            // Fixed problem!

            try
            {
                if (lbxVehicleResult.SelectedIndex > -1)
                {

                    int checkerInt = lbxVehicleResult.SelectedIndex;
                    tbxMakeModel.Text = availableVehicles.ElementAt(checkerInt).MakeAndModel;
                    tbxLicensePlate.Text = availableVehicles.ElementAt(checkerInt).LicensePlate;
                    tbxGasUsagePerKm.Text = availableVehicles.ElementAt(checkerInt).GasUsagePerKm.ToString();
                    tbxTotalKm.Text = availableVehicles.ElementAt(checkerInt).TotalKm.ToString();


                }



            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hey, something is wrong!");
            }






        }

        private void btnDelete_Click(object sender, EventArgs e) // This deletes a vehicle and removes it from the listbox
        {

            string licenseCheck = Convert.ToString(tbxLicenseCheck.Text);
            for (int index = 0; index < availableVehicles.Count(); index++)
            {
                if (licenseCheck == availableVehicles.ElementAt(index).LicensePlate)
                {
                    availableVehicles.RemoveAt(index);
                    lbxVehicleResult.Items.Clear();
                    ViewAvailableVehicles();

                }
            }
        }
        
        private void cbxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVehicleType.SelectedIndex.Equals(0))
            {


            }
        }

        private void btnListRides_Click(object sender, EventArgs e)
        {

        }
        //List all of the available rides
        private void btnListAvailableRides_Click(object sender, EventArgs e)
        {
            lbxAvaibleVehicles.Items.Clear();
            foreach (Vehicle v in availableVehicles)
            {
                lbxAvaibleVehicles.Items.Add(v.ToString());
            }
        }
        //List the rides in progress
        private void btnListRide_Click(object sender, EventArgs e)
        {
            lbxAvailable.Items.Clear();
            foreach (Vehicle v in availableVehicles)
            {
                lbxAvailable.Items.Add(v.ToString());
            }
        }
        //Book a ride
        public void btnBookRide_Click(object sender, EventArgs e)
        {
            if (cbxTransport.SelectedIndex == 0) {
                int passengers = Convert.ToInt32(tbxMaxPeopleRide.Text);
                bool available = false;
                double startingPrice = Convert.ToDouble(tbxInitialPrice.Text);
                double expectedKm = Convert.ToDouble(tbxExpectedKm.Text);
                DateTime startingTime = dtpDate.Value;
                foreach (var b in this.availableVehicles.ToList())
                {
                    if (!available)
                    {
                        if (b is Car)
                        {
                            if (((PassengerTransport)b).MaxPassengers >= passengers)
                            {
                                available = true;
                                Ride ride = new Ride(b, passengers, startingPrice, expectedKm, startingTime);
                                this.allRides.Add(ride);
                                this.availableVehicles.Remove(b);
                                foreach (Ride r in allRides)
                                {
                                    lbxBookedRide.Items.Add(r.ToString());
                                }

                            }
                        }
                        else if (b is Van)
                        {
                            if (((Van)b).MaxPassengers >= passengers)
                            {
                                double weight = Convert.ToDouble(tbxMaxWeightRide.Text);
                                double volume = Convert.ToDouble(tbxMaxVolumeRide.Text);
                                available = true;
                                Ride ride = new Ride(b, volume, weight, startingPrice, expectedKm, startingTime);
                                this.allRides.Add(ride);
                                this.availableVehicles.Remove(b);
                                foreach (Ride r in allRides)
                                {
                                    lbxBookedRide.Items.Add(r);
                                }
                            }
                        }
                    }

                }
                if (!available) { MessageBox.Show("Did not find a car!"); }
            }
            else if (cbxTransport.SelectedIndex == 1)
            {

                bool available = false;
                double startingPrice = Convert.ToDouble(tbxInitialPrice.Text);
                double expectedKm = Convert.ToDouble(tbxExpectedKm.Text);
                double MaxVolumeRide = Convert.ToDouble(tbxMaxVolumeRide.Text);
                double MaxWeightRide = Convert.ToDouble(tbxMaxWeightRide.Text);
                DateTime startingTime = dtpDate.Value;
                foreach (var b in this.availableVehicles.ToList())
                {
                    if (!available)
                    {
                        if (b is Truck)
                        {

                            if (((Truck)b).MaxVolume >= MaxVolumeRide && ((Truck)b).MaxWeight >= MaxWeightRide)
                            {
                                available = true;
                                Ride ride = new Ride(b, MaxVolumeRide, MaxWeightRide, startingPrice, expectedKm, startingTime);
                                this.allRides.Add(ride);
                                this.availableVehicles.Remove(b);

                                foreach (Ride r in allRides)
                                {
                                    lbxBookedRide.Items.Add(r);
                                }
                            }
                        }
                        else if (b is Van)
                        {
                            int passengers = Convert.ToInt32(tbxMaxPeopleRide.Text);
                            if (((Van)b).MaxPassengers >= passengers)
                            {

                                double weight = Convert.ToDouble(tbxMaxWeightRide.Text);
                                double volume = Convert.ToDouble(tbxMaxVolumeRide.Text);
                                available = true;
                                Ride ride = new Ride(b, volume, weight, startingPrice, expectedKm, startingTime);
                                this.allRides.Add(ride);
                                this.availableVehicles.Remove(b);
                                foreach (Ride r in allRides)
                                {
                                    lbxBookedRide.Items.Add(r);
                                }
                            }
                        }
                    }
                }
                if (!available) { MessageBox.Show("Did not find a car!"); }

            }


        }
        private void ShowBooked() /////////!!!
        {
            foreach (Vehicle v in vehicleOnRide)
            {
                lbxBookedRide.Items.Add(v);
            }

        }
        private void lbxAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAvailable.SelectedIndex > -1)
            {


            }
        }

        //Edit the information for each of the objects
        private void btnEdit_Click(object sender, EventArgs e)
        {



            int index = lbxVehicleResult.SelectedIndex;
            string makeAndModel = tbxMakeModel.Text;
            string licensePlate = tbxLicensePlate.Text;
            double gasUsagePerKm = Convert.ToDouble(tbxGasUsagePerKm.Text);
            double totalKm = Convert.ToDouble(tbxTotalKm.Text);



            availableVehicles[index].MakeAndModel = makeAndModel;
            availableVehicles[index].LicensePlate = licensePlate;
            availableVehicles[index].GasUsagePerKm = gasUsagePerKm;
            availableVehicles[index].TotalKm = totalKm;






            if (availableVehicles[index] is Car)
            {
                int maxPassengers = Convert.ToInt32(tbxMaxPeople.Text);
                ((PassengerTransport)availableVehicles[index]).MaxPassengers = maxPassengers;
                lbxVehicleResult.Items.Clear();
                ViewAvailableVehicles();
            }
            else if (availableVehicles[index] is Truck)
            {
                double maxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                double maxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                ((Freighter)availableVehicles[index]).MaxWeight = maxWeight;
                ((Freighter)availableVehicles[index]).MaxVolume = maxVolume;
                lbxVehicleResult.Items.Clear();
                ViewAvailableVehicles();
            }
            else if (availableVehicles[index] is Van)
            {
                int maxPassengers = Convert.ToInt32(tbxMaxPeople.Text);
                if (((Van)availableVehicles[index]).MaxPassengers > 0)
                {
                    ((Van)availableVehicles[index]).MaxPassengers = maxPassengers;
                    lbxVehicleResult.Items.Clear();
                    ViewAvailableVehicles();
                }
                else if (((Van)availableVehicles[index]).MaxVolume > 0 && ((Van)availableVehicles[index]).MaxWeight > 0)
                {
                    double maxWeight = Convert.ToDouble(tbxMaxWeight.Text);
                    double maxVolume = Convert.ToDouble(tbxMaxVolume.Text);
                    ((Van)availableVehicles[index]).MaxWeight = maxWeight;
                    ((Van)availableVehicles[index]).MaxVolume = maxVolume;
                    lbxVehicleResult.Items.Clear();
                    ViewAvailableVehicles();
                }
            }



        }

        private void rbtCar_CheckedChanged(object sender, EventArgs e)
        {

        }
        public List<Vehicle> ReadState1()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("AvailableVehicles.bin", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                return (List<Vehicle>)bf.Deserialize(fs);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong");
                return null;
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
        public List<Ride> ReadState2()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("AllRides.bin", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                return (List<Ride>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong");
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public void CreateOpenState1()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("AvailableVehicles.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                bf.Serialize(fs, availableVehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
            finally
            {
                if (fs != null) fs.Close();
            }



        }
        public void CreateOpenState2()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("AllRides.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();

                bf.Serialize(fs, allRides);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
            finally
            {
                if (fs != null) fs.Close();
            }



        }

        private void TransportationHub_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateOpenState1();
            CreateOpenState2();
        }

        private void btnEndRide_Click(object sender, EventArgs e) //Reminder: Re-do this!
        {
            if(lbxBookedRide.SelectedIndex > -1)
            {
                int index = lbxBookedRide.SelectedIndex;
                lbxBookedRide.Items.RemoveAt(index);
            }
        }

        private void TransportationHub_Load(object sender, EventArgs e)
        {
            ViewAvailableVehicles();
            ViewAllRides();
        }
    }

}