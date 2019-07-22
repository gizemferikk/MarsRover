using MarsRover.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayConsole(BuildString());
        }


        private static List<string> BuildString()
        {
            List<string> coordinateList = new List<string>();
            coordinateList.Add("5 5");
            coordinateList.Add("1 2 N");
            coordinateList.Add("LMLMLMLMM");
            coordinateList.Add("3 3 E");
            coordinateList.Add("MMRMMRMRRM");

            return coordinateList;
        }

        private static void DisplayConsole(List<string> coordinateList)
        {
            Console.WriteLine("Input:");
            DisplayInput(coordinateList);

            Console.WriteLine("Output:");
            DisplayOutput(coordinateList);
            Console.Write(Environment.NewLine);
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
        }

        private static void DisplayInput(List<string> coordinateList)
        {
            foreach (var coordinate in coordinateList)
            {
                Console.WriteLine(coordinate);
                Console.WriteLine(Environment.NewLine);
            }
        }
        private static void DisplayOutput(List<string> coordinateList)
        {
            var count = 2;

            Rover rover = null;
            Plateau plateau;
            plateau = Plateau.CreatePlateau(coordinateList[0]); 

            for (int i = 1; i < coordinateList.Count; i++)
            {
                if (coordinateList[i] != null)
                {
                    if (count % 2 == 0)
                    {
                        rover = Rover.CreateRover(coordinateList[i]);
                        rover.SetPlateau(plateau);
                    }
                    else
                    {
                        rover.ExecuteCommands(coordinateList[i]);
                        Console.WriteLine(rover.GetPosition());
                    }
                    count++;
                }


            }
        }
    }
}
