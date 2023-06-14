using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _5._Teamwork_Projects
{
    //public class Cars
    //{
    //    public Cars(string type, string model, string color, int horsePower)
    //    {
    //        this.TypeOfVehicle = type;
    //        this.ModelOfVehicle = model;
    //        this.ColorOfVehicle = color;
    //        this.HorsePowerOfVehicle = horsePower;

    //    }
    //    public string TypeOfVehicle { get; set; }
    //    public string ModelOfVehicle { get; set; }
    //    public string ColorOfVehicle { get; set; }
    //    public int HorsePowerOfVehicle { get; set; }
    //}
    //public class Trucks
    //{
    //    public Trucks(string typeOfVehicle, string modelOfVehicle, string colorOfVehicle, int horsePowerOfVehicle)
    //    {
    //        this.TypeOfVehicle = typeOfVehicle;
    //        this.ModelOfVehicle = modelOfVehicle;
    //        this.ColorOfVehicle = colorOfVehicle;
    //        this.HorsePowerOfVehicle = horsePowerOfVehicle;
    //    }

    //    public string TypeOfVehicle { get; set; }
    //    public string ModelOfVehicle { get; set; }
    //    public string ColorOfVehicle { get; set; }
    //    public int HorsePowerOfVehicle { get; set; }
}
public class VehicleCatalog
{
    public string TypeOfVehicle { get; set; }
    public string ModelOfVehicle { get; set; }
    public string ColorOfVehicle { get; set; }
    public int HorsePowerOfVehicle { get; set; }
    public VehicleCatalog(string typeOfVehicle, string modelOfVehicle, string color, int hp)
    {

        this.TypeOfVehicle = typeOfVehicle;
        this.ModelOfVehicle = modelOfVehicle;
        this.ColorOfVehicle = color;
        this.HorsePowerOfVehicle = hp;

    }
    public override string ToString()
    {
        string result = ($"Type: {TypeOfVehicle}\r\nModel: {ModelOfVehicle}\r\nColor: {ColorOfVehicle}\r\nHorsepower: {HorsePowerOfVehicle}");
        return result;
    }

}
internal class Program
{
    static void Main(string[] args)
    {


        List<VehicleCatalog> catalog = new List<VehicleCatalog>();


        
            string[] inputs = input.Split((" "), StringSplitOptions.RemoveEmptyEntries).ToArray();

            string typeOfVehicle = inputs[0];
            string model = inputs[1];
            string color = inputs[2];
            int horsePower = int.Parse(inputs[3]);
            if (typeOfVehicle == "car")
            {
                typeOfVehicle = "Car";
            }
            else if (typeOfVehicle == "truck")
            {
                typeOfVehicle = "Truck";
            }
            var vehicle = new VehicleCatalog(typeOfVehicle, model, color, horsePower);

            catalog.Add(vehicle);

        }

        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            for (int i = 0; i < catalog.Count; i++)
            {
                string currModel = catalog[i].ModelOfVehicle;
                string currModelInput = input;

                if (currModel == currModelInput)
                {
                    Console.WriteLine(catalog[i]);
                }
            }
        }
        var cars = catalog.Where(x => x.TypeOfVehicle == "Car").ToList();

        var trucks = catalog.Where(x => x.TypeOfVehicle == "Truck").ToList();

        if (cars.Count > 0)
        {
            var averageCarsHP = cars.Average(x => x.HorsePowerOfVehicle);
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHP:f2}.");
        }
        else
        {
            Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
        }
        if (trucks.Count > 0)
        {
            var averageTrucksHP = trucks.Average(x => x.HorsePowerOfVehicle);
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:f2}.");
        }
        else
        {
            Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }

    }

}
