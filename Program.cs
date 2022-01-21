using System;

namespace ctech9.SquawkCodeGenerator {
    class Program {
        static void Main(string[] args) {
            int[] code = new int[4];
            string codeToString = "";
            List<string> prevCodes = new List<string>();
            Random rand = new Random();
            ConsoleKeyInfo userInput;
            ConsoleKeyInfo userInput2;
            Console.WriteLine("Press R to reset list. \nPress Q to quit the program. \nPress any key to generate another code. \n");
            while (true) {
                for (int i = 0; i < 4; i++) {
                    code[i] = rand.Next(0,7);
                }
                codeToString = string.Join("", code);
                if (codeToString  == "7500" || codeToString == "7600" || codeToString == "7700" || prevCodes.Contains(codeToString)) continue;
                Console.WriteLine(codeToString);
                userInput = Console.ReadKey();

                switch (userInput.Key) {
                    case ConsoleKey.R:
                        prevCodes.Clear();
                        break;

                    case ConsoleKey.Q:
                        Console.WriteLine("Really Quit?");
                        userInput2 = Console.ReadKey();
                        switch (userInput2.Key) {
                            case ConsoleKey.Y:
                                System.Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}