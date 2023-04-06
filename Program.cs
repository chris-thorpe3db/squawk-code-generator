using System;
using System.Collections.Generic;

namespace SquawkCodeGenerator {
    class Program {
        static void Main(string[] args) {
            // Generate variables for code generation/memory
            int[] code = new int[4];
            string codeToString = "";
            List<string> prevCodes = new List<string>();
            Random rand = new Random();
            
            // User input variables
            ConsoleKeyInfo userInput;
            ConsoleKeyInfo userInput2;
            
            // Instruction
            Console.WriteLine("Press R to reset list. \nPress Q to quit the program. \nPress any key to generate another code. \n");
            
            // Start of while loop
            while (true) {
                // Generate code digit by digir
                for (int i = 0; i < 4; i++) {
                    code[i] = rand.Next(0,7);
                }
                
                // Convert int array to string so we can compare
                codeToString = string.Join("", code);
                
                // Compare string to emergency codes, vfr code, and previously used codes
                if (codeToString  == "7500" || codeToString == "7600" || codeToString == "7700" || codeToString == "1200" || prevCodes.Contains(codeToString)) continue;
                
                //If good, add to list of used codes, print, and wait for user input
                prevCodes.Add(codeToString);
                Console.WriteLine(codeToString);
                userInput = Console.ReadKey();

                switch (userInput.Key) {
                    
                    // Clear list on R, break case switch
                    case ConsoleKey.R:
                        prevCodes.Clear();
                        break;

                    // Quit routine on Q
                    case ConsoleKey.Q:
                        Console.WriteLine("Really Quit?");
                        userInput2 = Console.ReadKey();
                        
                        // Confirm if user wants to quit
                        switch (userInput2.Key) {
                            // On Y, quit with code 0. Else, break case switch
                            case ConsoleKey.Y:
                                System.Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        // Break case switch on any key that isn't Q or R
                        break;
                }
            }
        }
    }
}
