using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NewYearsResolutions
{
    class Resolution
    {
        public string Description;

        public Resolution(string _Description)
        {
            Description = _Description;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Resolutions\Resolutions.txt";
            string directoryPath = @"C:\Resolutions";

            Console.WriteLine("Write your new year resolutions seperated by comma and space:");
            string resolutions = Console.ReadLine();
            List<string> resolutionList = new List<string>();

            foreach (string item in resolutions.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                resolutionList.Add(item);
            }

            Directory.CreateDirectory(directoryPath);
            File.WriteAllLines(path, resolutionList);

            foreach(string line in File.ReadLines(path))
            {
                Resolution resolution = new Resolution(line);
                Console.WriteLine(resolution.Description);
            }
            Console.WriteLine("Write a resolution you would like to add to the list");
            string addResolution = Console.ReadLine();
            resolutionList.Add(addResolution);
            foreach(string item in resolutionList)
            {
                Console.WriteLine(item);
            }
            File.WriteAllLines(path, resolutionList);
            Console.WriteLine("Write a resolution you would like to remove from the list");
            string removeResolution = Console.ReadLine();
            resolutionList.Remove(removeResolution);
            foreach (string item in resolutionList)
            {
                Console.WriteLine(item);
            }
            File.WriteAllLines(path, resolutionList);
        } 

    }

}
