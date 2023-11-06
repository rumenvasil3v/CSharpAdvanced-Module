using System.Runtime.CompilerServices;
using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        private List<Vehicle> vehicles;
        private int capacity;

        public RepairShop(int capacity)
        {
            this.Vehicles = new List<Vehicle>();
            this.Capacity = capacity;
        }

        public List<Vehicle> Vehicles { get { return this.vehicles; } set { this.vehicles = value; } }
        
        public int Capacity { get { return this.capacity; } set { this.capacity = value; } }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicles.Count < this.Capacity)
            {
                vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            bool doesItExist = false;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.VIN == vin)
                {
                    vehicles.Remove(vehicle);
                    doesItExist = true;
                    break;
                }
            }

            return doesItExist;
        }

        public int GetCount()
        {
            return this.vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            var vehicle = vehicles.MinBy(x => x.Mileage);

            return vehicle;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var vehicle in vehicles)
            {
                sb.AppendLine($"{vehicle.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}