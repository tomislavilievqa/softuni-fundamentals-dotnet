using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _8._Vehicle_Catalogue
{
    //Define a class Truck with the following properties: Brand, Model and Weight.
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    //Define a class Car with the following properties: Brand, Model and Horse Power.
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    //Define a class Catalog with the following properties: Collections of Trucks and Cars.
    public class Catalog
    {

        //Catalog(List<Car> cars, List<Truck> trucks)
        //{
        //    this.Cars = cars;
        //    this.Trucks = trucks;
        //}
        //Catalog(List<Car> cars)
        //{
        //    this.Cars = cars;
        //}
        //Catalog(List<Truck> trucks)
        //{
        //    this.Trucks = trucks;
        //}

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input = Console.ReadLine();
            bool isCar = false;
            bool isTruck = false;

            while (input != "end")
            {
                string[] inputs = input.Split("/").ToArray();

                if (inputs[0].ToString() == "Car")
                {
                    string carName = inputs[0];
                    string carModel = inputs[2];
                    string carBrand = inputs[1];
                    int carHorsePower = int.Parse(inputs[3]);

                    Car car = new Car(carBrand, carModel, carHorsePower);

                    cars.Add(car);
                    isCar = true;
                }
                else if (inputs[0].ToString() == "Truck")
                {
                    string truckName = inputs[0];
                    string truckModel = inputs[2];
                    string truckBrand = inputs[1];
                    int truckWeight = int.Parse(inputs[3]);

                    Truck truck = new Truck(truckBrand, truckModel, truckWeight);

                    trucks.Add(truck);
                    isTruck = true;
                }

                input = Console.ReadLine();
            }

            Catalog catalog = new Catalog();
            catalog.Cars = cars.OrderBy(cars => cars.Brand).ToList();
            catalog.Trucks = trucks.OrderBy(trucks => trucks.Brand).ToList();


            if (isCar)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (isTruck)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }



    }
}