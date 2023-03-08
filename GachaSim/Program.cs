using System;
using System.IO;
using System.Diagnostics;
using GachaSimLibrary;

namespace GachaSim
{
    public class SimProgram
    { 
        static void Main(string[] args)
        {
            // Boolean value to determine whether the app should remain open or close
            bool endApp = false;

            // Reference to functions used throughout
            Functions func = new Functions();

            // Menu text string
            string menuText = "Please insert the corresponding input to the desired function, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Basic Simulation - Rolls needed to hit a drop rate of 5%\n" +
                              "2: Basic Step Simulation - Choose single or ten rolls at once until a drop rate of 5% is hit\n" +
                              "3: Standard Step Simulation - Equivalent to Basic Step Simulation with additional individual item rarity\n" +
                              "4: Standard Pity Simulation V1 - Implementation of 4* and 5* pity systems to Standard Step Simulation\n" +
                              "5: Standard Pity Simulation V2 - Alternate implementation of 4* and 5* pity systems to Standard Step Simulation\n" +
                              "6: Advanced Simulation - Implementation of techniques from prominent examples, alongside user stipulation on variables\n" +
                              "X: Exit application\n";

            // Give initial instructions to the user
            Console.WriteLine("Welcome to Gacha Simulator!\n" + Environment.NewLine + menuText);

            while (!endApp)
            {
                // Declare variable and obtain the user input
                string input = Console.ReadLine();

                // Use inputted variable to select function
                switch (input)
                {
                    case "1":
                        // Call Basic Simulation function
                        int output = func.BasicSimulation();

                        // Print result and menu text
                        Console.WriteLine($"\nRolls conducted to hit the drop rate = {output}\n");
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "2":
                        // Call Basic Step Simulation function
                        func.BasicStepSimulation();
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "3":
                        // Call Standard Step Simulaton function
                        func.StandardStepSimulation();
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "4":
                        // Call Standard Pity Simulation V1 function
                        func.StandardPitySimulationV1();
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "5":
                        // Call Standard Pity Simulation V1 function
                        func.StandardPitySimulationV2();
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "6":
                        // Call Advanced Simulation function
                        func.AdvancedSimulation();
                        Console.WriteLine("Your function has concluded!\n\n" + Environment.NewLine + menuText);
                        break;

                    case "X":
                        // Exit the application through boolean variable
                        endApp = true;
                        break;

                    default:
                        // Prompt user to input again if invalid
                        Console.WriteLine("\nInvalid input! Please try again.\n" + Environment.NewLine + menuText);
                        break;
                }
            }
        }
    }
}

