using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {                                               //String array to represent the colors of each number on the roulette board
            int z = 0;
            string[] rouletteColors = new string[38] {"green", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black",
            "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black", "red", "black","red", "black", "black", "red", "black", "red","black",
            "red", "black", "red", "green"};
            string[] rouletteNumbers = new string[38];    //Array of 38 to represent the 37 spaces on the roulette board
            Functions func = new Functions();
            Random ran = new Random();
            Functions color = new Functions();
            Functions lowhigh = new Functions();                //All the bets from the Functions class
            Functions thirds = new Functions();
            Functions columns = new Functions();
            Functions rows = new Functions();
            Functions doubStreet = new Functions();
            Functions splits = new Functions();
            Functions corners = new Functions();
            do
            {
                int numb = ran.Next(0, 38);                     //Random Number Generator
                int x;                                          //Menu
                Console.WriteLine("Welcome to the Casino! Lets play some roulette.\n Press 1. to play roulette, or press 2. to quit.");
                string read = Console.ReadLine();
                while (Int32.TryParse(read, out x) == false || x != 1 && x != 2)
                {
                    Console.WriteLine("That is not an option. Try again.");                 //While loop telling the program to C.WL "That is not an option"
                    read = Console.ReadLine();                                              //If the user does not enter 1 or 2
                }
                switch (x)
                {
                    case 1: 
                        Console.WriteLine($"\nYou rolled {numb}.\n");
                        Console.ReadKey();
                        Console.WriteLine($"Your winning number for a straight is {numb}.");
                        Console.WriteLine($"{func.EvenOdd(rouletteNumbers, numb)}");                    //Calling the methods of all bets from the functions class
                        Console.WriteLine($"{color.Colors(rouletteNumbers, numb)}");
                        Console.WriteLine($"{lowhigh.LowtToHigh(rouletteNumbers, numb)}");
                        Console.WriteLine($"{thirds.Dozens(rouletteNumbers, numb)}");
                        Console.WriteLine($"{columns.Columns(rouletteNumbers, numb)}");                 
                        Console.WriteLine($"{rows.Street(rouletteNumbers, numb)}");
                        Console.WriteLine($"{doubStreet.DoubleStreet(rouletteNumbers, numb)}");
                        Console.WriteLine($"{splits.Split(rouletteNumbers, numb)}");
                        Console.WriteLine($"{corners.Corners(rouletteNumbers, numb)}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:                       
                        z++;    //If the user chooses "2" it will incriment z which would end the do-while loop and exit the program.
                        break;
                }
            } while (z == 0);    
        }
        
    }
}
