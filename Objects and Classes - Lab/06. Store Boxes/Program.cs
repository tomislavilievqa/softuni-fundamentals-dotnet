using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace _6._Store_Boxes
{
    class Item
    {
        //Name and Price.

        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        //Serial Number, Item, Item Quantity and Price for a Box

        //The Price of one box has to be calculated: itemQuantity * itemPrice.

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }

        public override string ToString()
        {
            string result = $"{SerialNumber} " + Environment.NewLine +
                $"-- {Item.Name} - {Item.Price.ToString("F2")}: ${ItemQuantity} " + Environment.NewLine +
                $"-- ${PriceForABox.ToString("F2")}";

            return result;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Until you receive "end", you will be receiving data in the following format: {Serial Number} {Item Name} {Item Quantity} {itemPrice}

            List<Box> storeBoxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split(' ').ToArray();

                int serialNum = int.Parse(inputs[0]);
                string itemName = inputs[1];
                int itemQuantity = int.Parse(inputs[2]);
                double itemPrice = double.Parse(inputs[3]);

                Box box = new Box();
                box.Item = new Item(itemName, itemPrice);
                box.SerialNumber = serialNum;
                box.ItemQuantity = itemQuantity;
                box.PriceForABox = itemPrice * itemQuantity;

                storeBoxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> filteredList= storeBoxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (Box box in filteredList)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity} ");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }


        }
    }
}

