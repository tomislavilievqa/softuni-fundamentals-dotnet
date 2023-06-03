using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _3._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string message = string.Empty;

            while ((message = Console.ReadLine()) != "find")
            {
                char[] decriptedMessage = message.ToCharArray();

                int[] multipliedKey = new int[message.Length];

                int countItterations = 0;

                for (int j = 0; j < message.Length; j++)
                {
                    if (countItterations < key.Length)
                    {
                        multipliedKey[j] = key[j];
                        countItterations++;
                    }
                    else
                    {
                        multipliedKey[j] = multipliedKey[j - key.Length];
                    }
                }


                for (int i = 0; i < message.Length; i++)
                {
                    decriptedMessage[i] -= (char)multipliedKey[i];
                }

                string result = new string(decriptedMessage);


                int startIndexOfType = result.IndexOf('&');
                int endIndexOfType = result.LastIndexOf('&');
                int startIndexOfCoordinates = result.IndexOf('<');
                int endIndexOfCoordinates = result.IndexOf('>');

                string type = result.Substring(startIndexOfType + 1, endIndexOfType - startIndexOfType - 1);
                string coordinates = result.Substring(startIndexOfCoordinates + 1, endIndexOfCoordinates - startIndexOfCoordinates - 1);

                Console.WriteLine($"Found {type} at {coordinates}");

            }


        }
        
        static void MultiplicateArray(int[] key, string message )
        {
            int[] multipliedKey = new int[message.Length];

            int countItterations = 0;

            for (int j = 0; j < message.Length; j++)
            {
                if (countItterations < key.Length)
                {
                    multipliedKey[j] = key[j];
                    countItterations++;
                }
                else
                {
                    multipliedKey[j] = multipliedKey[j - key.Length];
                }
            }

     
        }



    }
}