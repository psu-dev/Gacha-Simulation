using System;
using System.IO;
using System.Diagnostics;

namespace GachaSimLibrary
{
    public class Functions
    {
        // Basic random number generator with a single parameter check
        public int BasicSimulation()
        {
            // Variables: return value, temporary int to observe, the random number generator, boolean for the loop and results log
            int result = 0;
            int temp;
            Random rnd = new Random();
            bool endSim = false;
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Basic Simulation:\n");

            // Loop through random numbers between 0 and 99
            while (!endSim)
            {
                // Set temp to new random value with each iteration, and increase result value to represent the number of iterations conducted
                temp = rnd.Next(100);
                result++;

                // End loop if drop rate (5%) is hit
                if(temp >= 95)
                {
                    endSim = true;
                }
            }
            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            return result;
        }



        // Single parameter check operable singularly or in steps of ten
        public void BasicStepSimulation()
        {
            // Variables: return value, temporary variable for calculation, random number generator, boolean for looping, user input string, menu text string, results log
            int result = 0;
            int temp = 0;
            Random rnd = new Random();
            bool endSim = false;
            string input;
            string menuText = "\nPlease insert the corresponding input to roll a single time or ten times, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Single roll\n" +
                              "2: Ten rolls";
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Basic Step Simulation:\n");

            // Maintain the process until the drop rate is hit
            while (!endSim)
            {
                // Give instructions to user
                Console.WriteLine(menuText);

                // Obtain user input
                input = Console.ReadLine();

                switch(input)
                {
                    // Single pull process from BasicSimulation
                    case "1":
                        // Note the pull type to the log
                        log.WriteLine("Single pull");

                        temp = rnd.Next(100);
                        result++;

                        if (temp >= 95)
                        {
                            endSim = true;
                            break;
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    // Ten pull process: repeat the single pull process ten times through a for loop
                    case "2":
                        // Note the pull type to the log
                        log.WriteLine("Ten pull");

                        for (int i = 0; i < 10; i++)
                        {
                            temp = rnd.Next(100);
                            result++;

                            if (temp >= 95)
                            {
                                endSim = true;
                                break;
                            }
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    default:
                        // Prompt the user to input again if invalid
                        Console.WriteLine("Invalid input! Please try again.\n");
                        break;
                }

            }

            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            // Print the number of pulls used to obtain a 5*
            Console.WriteLine($"Total pulls used: {result}\n");
        }



        // Three parameter checks operable singularly or in steps of ten
        public void StandardStepSimulation()
        {
            // Variables: return value, temporary variable for calculation, random number generator, boolean for looping, user input string, menu text string, results log
            int result = 0; int temp = 0;
            Random rnd = new Random();
            bool endSim = false;
            string input;
            string menuText = "\nPlease insert the corresponding input to roll a single time or ten times, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Single roll\n" +
                              "2: Ten rolls\n";
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Standard Step Simulation:\n");

            // Maintain the process until the drop rate is hit
            while (!endSim)
            {
                // Give instructions to user
                Console.WriteLine(menuText);

                // Obtain user input
                input = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                switch(input)
                {
                    // Expand the BasicSimulation process to check more parameters and output the according rarity obtained
                    case "1":
                        // Note the pull type to the log
                        log.WriteLine("Single pull:");

                        temp = rnd.Next(100);
                        result++;

                        // 70% chance of getting the most common 3* item
                        if (temp < 70)
                        {
                            log.WriteLine("3* item");
                            Console.WriteLine("3* item");
                        }

                        // 25% chance of getting the rarer 4* item
                        else if (temp >= 70 && temp < 95)
                        {
                            log.WriteLine("4* item");
                            Console.WriteLine("4* item");
                        }
                        
                        // 5% chance of getting the super rare 5* item, which also ends the process
                        else
                        {
                            log.WriteLine("5* item!");
                            Console.WriteLine("5* item!");
                            endSim = true;
                            break;
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    // Once again use the single pull process ten times for the ten pull with a for loop
                    case "2":
                        // Note the pull type to the log
                        log.WriteLine("Ten pull:");

                        for (int i = 0; i < 10; i++)
                        {
                            temp = rnd.Next(100);
                            result++;

                            if (temp < 70)
                            {
                                log.WriteLine("3* item");
                                Console.WriteLine("3* item");
                            }

                            else if (temp >= 70 && temp < 95)
                            {
                                log.WriteLine("4* item");
                                Console.WriteLine("4* item");
                            }

                            else
                            {
                                log.WriteLine("5* item!");
                                Console.WriteLine("5* item!");
                                endSim = true;
                                break;
                            }
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    default:
                        // Prompt the user to input again if invalid
                        Console.WriteLine("Invalid input! Please try again.\n");
                        break;
                }

            }

            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            // Print the number of pulls used to obtain a 5*
            Console.WriteLine($"Total pulls used: {result}\n");
        }



        // Single or ten step, triple parameter operation with guarantees to obtain certain outcomes if circumstance dictates 
        public void StandardPitySimulationV1()
        {
            // Variables: return value, temporary variables for calculation, random number generator and 5* pity, booleans for looping and 4* check, user input string, menu text string, results log
            int result = 0; int temp = 0; int fivePity = 0;
            Random rnd = new Random();
            bool endSim = false; bool fourPity = false;
            string input;
            string menuText = "\nPlease insert the corresponding input to roll a single time or ten times, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Single roll\n" +
                              "2: Ten rolls\n";
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Standard Pity Simulation V1:\n");

            // Maintain process until the drop rate is hit
            while (!endSim)
            {
                // Give instructions to user
                Console.WriteLine(menuText);

                // Obtain user input
                input = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                switch(input)
                {
                    // if statement order has been swapped to prevent 4* rate being affected once pity starts influencing 5* rate
                    // 5* base rate reduced to 2% and climbs by 2% with each pull that isn't 5* rarity made over 50 total pulls
                    case "1":
                        // Note the pull type to the log
                        log.WriteLine("Single pull:");

                        temp = rnd.Next(100);
                        result++;

                        // If the total pulls made exceeds 50, set the percentage increase through doubling the difference of the total and pity cap
                        if (result > 50)
                        {
                            fivePity = (result - 50) * 2;
                        }

                        if (temp < 25)
                        {
                            log.WriteLine("4* item");
                            Console.WriteLine("4* item");
                        }

                        // The 5* pity variable remains zero until the pulls exceed 50, then the value begins to reduce the 3* rate and increase the 5* rate
                        else if (temp >= 25 && temp < 98 - fivePity)
                        {
                            log.WriteLine("3* item");
                            Console.WriteLine("3* item");
                        }

                        else
                        {
                            log.WriteLine("5* item!");
                            Console.WriteLine("5* item!");
                            endSim = true;
                            break;
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;
                    
                    // Inclusion of the 5* pity adjustments alongside 4* check to guarantee at least one is obtained in a ten pull
                    case "2":
                        // Note the pull type to the log
                        log.WriteLine("Ten pull:");

                        for (int i = 0; i < 10; i++)
                        {
                            temp = rnd.Next(100);
                            result++;

                            if (result > 50)
                            {
                                fivePity = (result - 50) * 2;
                            }

                            // Guarantee the 4* if the last iteration is reached without obtaining one prior
                            if (temp < 25 || (i == 9 && fourPity == false))
                            {
                                log.WriteLine("4* item");
                                Console.WriteLine("4* item");
                                fourPity = true;
                            }

                            else if (temp >= 25 && temp < 98 - fivePity)
                            {
                                log.WriteLine("3* item");
                                Console.WriteLine("3* item");
                            }

                            else
                            {
                                log.WriteLine("5* item!");
                                Console.WriteLine("5* item!");
                                endSim = true;
                                break;
                            }
                        }

                        // Reset the 4* check
                        fourPity = false;

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    default:
                        // Prompt the user to input again if invalid
                        Console.WriteLine("Invalid input! Please try again.\n");
                        break;
                }

            }
            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            // Print the number of pulls used to obtain a 5*
            Console.WriteLine($"Total pulls used: {result}\n");
        }



        // Single or ten step, triple parameter operation with alternate methods to guarantee outcomes
        public void StandardPitySimulationV2()
        {
            // Variables: return value, temporary variables for calculation, random number generator and 4* pity, boolean for looping, user input string, menu text string, results log
            int result = 0; int temp = 0; int fourPity = 0;
            Random rnd = new Random();
            bool endSim = false;
            string input;
            string menuText = "\nPlease insert the corresponding input to roll a single time or ten times, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Single roll\n" +
                              "2: Ten rolls\n";
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Standard Pity Simulation V2:\n");

            // Maintain process until the drop rate is hit
            while (!endSim)
            {
                // Give instructions to user
                Console.WriteLine(menuText);

                // Obtain user input
                input = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                switch (input)
                {
                    // if statement order has been swapped for clarity in the process
                    // 5* base rate is 2%, but is guaranteed after 50 pulls if the rate isn't hit prior
                    // 4* pity now also applies to single rolls, guaranteeing a 4* within 10 pulls
                    case "1":
                        // Note the pull type to the log
                        log.WriteLine("Single pull:");

                        temp = rnd.Next(100);
                        result++;

                        // 5* guaranteed after 50 pulls
                        if (temp < 2 || result == 50)
                        {
                            log.WriteLine("5* item!");
                            Console.WriteLine("5* item!");
                            endSim = true;
                            break;
                        }

                        // 4* guaranteed if the pulls without obtaining one around about to exceed 10, variable is reset upon obtaining a 4*
                        else if ((temp >= 2 && temp < 27) || fourPity == 9)
                        {
                            log.WriteLine("4* item");
                            Console.WriteLine("4* item");
                            fourPity = 0;
                        }

                        // Increase the fourPity variable when a 3* is pulled
                        else
                        {
                            log.WriteLine("3* item");
                            Console.WriteLine("3* item");
                            fourPity++;
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    // Single pull method changes applied
                    case "2":
                        // Note the pull type to the log
                        log.WriteLine("Ten pull:");

                        for (int i = 0; i < 10; i++)
                        {
                            temp = rnd.Next(100);
                            result++;

                            if (temp < 2 || result == 50)
                            {
                                log.WriteLine("5* item1");
                                Console.WriteLine("5* item!");
                                endSim = true;
                                break;
                            }

                            else if ((temp >= 2 && temp < 27) || fourPity == 9)
                            {
                                log.WriteLine("4* item");
                                Console.WriteLine("4* item");
                                fourPity = 0;
                            }

                            else
                            {
                                log.WriteLine("3* item");
                                Console.WriteLine("3* item");
                                fourPity++;
                            }
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    default:
                        // Prompt the user to input again if invalid
                        Console.WriteLine("Invalid input! Please try again.\n");
                        break;
                }

            }

            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            // Print the number of pulls used to obtain a 5*
            Console.WriteLine($"Total pulls used: {result}\n");
        }



        // Single or ten step, triple parameter operation with researched technqiues from prominent examples applied
        public void AdvancedSimulation()
        {
            // Variables: return value, temp for calculation, 4* and 5* pity, hard pity and soft pity caps, pull rate and pull rate increase,
            // boolean for looping, user input string, menu text string, random number generator, results log
            int result = 0; int temp = 0; int fourPity = 0;
            double fivePity = 0;
            int hardPity;
            double pullRate, softPity, stepRate, stepRateTemp;
            // Alternate method for random generation which differs from being based on the system clock as before
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            bool endSim = false;
            string input;
            string menuText = "\nPlease insert the corresponding input to roll a single time or ten times, and press Enter.\n" +
                              Environment.NewLine +
                              "1: Single roll\n" +
                              "2: Ten rolls\n";
            using StreamWriter log = new StreamWriter("Results.txt", true);

            // Note which function has been selected to the log
            log.WriteLine("Advanced Simulation:\n");

            // Obtain user inputs for hard pity cap and 5* pull rates, converting them int or double where necessary
            Console.WriteLine(Environment.NewLine + "\nPlease input an integer value for the pull limit of a 5* (value between 50 - 100 recommended).\n");

            // Utilise a while loop and TryParse function to ensure the user inputs correctly
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out hardPity) && hardPity > 0) { break; }
                else { Console.WriteLine("\nInvalid input! Please try again.\n"); }
            }

            Console.WriteLine("\nPlease input a double value for the percentage pull rate of a 5* (input will be rounded to the nearest single decimal, 0.5 - 5% recommended).\n");

            // Use same process as before with an extra calculation to scale up the rates so they align with increased random number generator parameters later
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out pullRate) && pullRate > 0)
                {
                    pullRate = Math.Round(pullRate, 1, MidpointRounding.ToEven) * 10;
                    break;
                }

                else { Console.WriteLine("\nInvalid input! Please try again.\n"); }
            }
            
            // Obtain the soft pity cap by calculating 75% of the hard pity cap and rounding to a whole number
            softPity = Math.Round((hardPity * 0.75), 1, MidpointRounding.ToEven);

            // Obtain the percentage increase per pull once soft pity cap has been hit, so pulls do not exceed hard pity cap
            stepRateTemp = (100 - pullRate) / (hardPity - softPity);
            stepRate = Math.Round(stepRateTemp, 1, MidpointRounding.ToEven);

            // Write the input and calculated variables to the log
            log.WriteLine($"Hard Pity: {hardPity}, Soft Pity: {softPity}, Pull Rate: {pullRate / 10}, Step Rate: {stepRate}\n");

            // Maintain process until the drop rate is hit
            while (!endSim)
            {
                // Give instructions to user
                Console.WriteLine(menuText);

                // Obtain user input
                input = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                switch (input)
                {
                    case "1":
                        // Note the pull type to the log
                        log.WriteLine("Single pull:");

                        // Increase in random number generation parameters to allow for single decimal point pull rates
                        temp = rnd.Next(1000);
                        result++;

                        // Apply pull rate increase once pulls have exceeded soft pity cap
                        if (result > softPity)
                        {
                            fivePity = ((result - softPity) * stepRate) * 10;
                        }
                        
                        // 4* check placed first such that increasing rates doesn't affect 4* rates, as well as a 5* not occuring if 4* pity is guaranteed
                        if (temp < 100 || fourPity == 9)
                        {
                            log.WriteLine("4* item");
                            Console.WriteLine("4* item");
                            fourPity = 0;
                        }

                        // Increase 5* pull rates by the determined fivePity variable, remains zero if parameters haven't been met
                        else if (temp >= 100 && temp < pullRate + fivePity)
                        {
                            log.WriteLine("5* item!");
                            Console.WriteLine("5* item!");
                            endSim = true;
                            break;
                        }

                        else
                        {
                            log.WriteLine("3* item");
                            Console.WriteLine("3* item");
                            fourPity++;
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;
                    
                    // Single pull method changes applied
                    case "2":
                        // Note the pull type to the log
                        log.WriteLine("Ten pull:");

                        for (int i = 0; i < 10; i++)
                        {
                            temp = rnd.Next(1000);
                            result++;

                            if (result > softPity)
                            {
                                fivePity = ((result - softPity) * stepRate) * 10;
                            }

                            if (temp < 100 || fourPity == 9)
                            {
                                log.WriteLine("4* item");
                                Console.WriteLine("4* item");
                                fourPity = 0;
                            }

                            else if (temp >= 100 && temp < pullRate + fivePity)
                            {
                                log.WriteLine("5* item!");
                                Console.WriteLine("5* item!");
                                endSim = true;
                                break;
                            }

                            else
                            {
                                log.WriteLine("3* item");
                                Console.WriteLine("3* item");
                                fourPity++;
                            }
                        }

                        // Note the current pulls to the log
                        log.WriteLine($"\nCurrent pulls used: {result}\n");

                        // Print the current number of pulls used
                        Console.WriteLine($"\nCurrent pulls used: {result}\n");
                        break;

                    default:
                        // Prompt the user to input again if invalid
                        Console.WriteLine("Invalid input! Please try again.\n");
                        break;
                }
               
            }

            // Note the results to the log
            log.WriteLine($"Total pulls for 5*: {result}\n" + Environment.NewLine);

            // Print the number of pulls used to obtain a 5*
            Console.WriteLine($"Total pulls used: {result}\n");
        }
    }
}