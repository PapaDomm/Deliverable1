using System;
using System.Dynamic;

public class Deliverable1
{
    public static void Main()
    {
        //Declare Soda variables//
        int soda_stock = 100;
        int soda_restock = 40;
        int soda_input = 101;
        bool soda_rebool = false;

        //Declare Chips variables//
        int chips_stock = 40;
        int chips_restock = 20;
        int chips_input = 101;
        bool chips_rebool = false;

        //Declare Candy variables//
        int candy_stock = 60;
        int candy_restock = 40;
        int candy_input = 101;
        bool candy_rebool = false;

        //Setup variables for starting program loop//
        bool restocker = false;
        string start_prog = "";


        //While loop to ask the user if they would like to use the program//
        //Loops until the user gives a valid answer//
        while (start_prog.ToUpper() != "Y" && start_prog.ToUpper() != "N")
        {
            Console.WriteLine("Would you like to adjust the stock values?(Y or N): ");
            start_prog = Console.ReadLine();

            if (start_prog.ToUpper() == "Y")
            {
                Console.WriteLine();
                Console.WriteLine("Great, let's get started!");
                Console.WriteLine();
                restocker = true;
            }
            else if (start_prog.ToUpper() == "N")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you anyway, have a nice day! ");
                Console.WriteLine();
            }
        }


        //Our main program loop//
        while (restocker)
        {
            //reset input values//
            soda_input = 101;
            chips_input = 101;
            candy_input = 101;

            Console.WriteLine();
            Console.WriteLine("Welcome to the Restocking tool!");
            Console.WriteLine();

            //Our soda stocking loop//
            Console.WriteLine("How many Sodas were sold today? " + soda_stock + " in stock.");
            while (soda_input > soda_stock)
            {
                soda_input = int.Parse(Console.ReadLine());

                if (soda_input > soda_stock)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if (soda_stock - soda_input <= soda_restock)
                {
                    soda_rebool = true;
                    soda_stock -= soda_input;
                    soda_input = 0;
                    Console.WriteLine();
                    Console.WriteLine("There are " + soda_stock + " Sodas left!");
                    Console.WriteLine();
                }
                else
                {
                    soda_stock -= soda_input;
                    Console.WriteLine();
                    Console.WriteLine("There are " + soda_stock + " Sodas left!");
                    Console.WriteLine();
                }
            }

            //Our Chips stocking loop//
            Console.WriteLine("How many Chips were sold today? " + chips_stock + " in stock.");
            while (chips_input > chips_stock)
            {
                chips_input = int.Parse(Console.ReadLine());

                if (chips_input > chips_stock)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if (chips_stock - chips_input <= chips_restock)
                {
                    chips_rebool = true;
                    chips_stock -= chips_input;
                    chips_input = 0;
                    Console.WriteLine();
                    Console.WriteLine("There are " + chips_stock + " Chips left!");
                    Console.WriteLine();
                }
                else
                {
                    chips_stock -= chips_input;
                    Console.WriteLine();
                    Console.WriteLine("There are " + chips_stock + " Chips left!");
                    Console.WriteLine();
                }
            }

            //Our Candy stocking loop//
            Console.WriteLine("How many Candies were sold today? " + candy_stock + " in stock.");
            while (candy_input > candy_stock)
            {
                candy_input = int.Parse(Console.ReadLine());

                if (candy_input > candy_stock) 
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if (candy_stock - candy_input <= candy_restock)
                {
                    candy_rebool = true;
                    candy_stock -= candy_input;
                    candy_input = 0;
                    Console.WriteLine();
                    Console.WriteLine("There are " + candy_stock + " Candies left!");
                    Console.WriteLine();
                }
                else
                {
                    candy_stock -= candy_input;
                    Console.WriteLine();
                    Console.WriteLine("There are " + candy_stock + " Candies left!");
                    Console.WriteLine();
                }
            }

            //Restocking Final prints//

            //If all 3 need to be restocked//
            if (soda_rebool && chips_rebool && candy_rebool)
            {
                Console.WriteLine();
                Console.WriteLine("Everything needs to be restocked!! Hurry up!");
                Console.WriteLine();
                restocker = false;
                System.Environment.Exit(0);
            }

            //If only some products need to be restocked//
            else if (soda_rebool | chips_rebool | candy_rebool)
            {
                Console.WriteLine();
                Console.WriteLine("Thanks for filling out the values, here's what needs to be restocked. ");
                Console.WriteLine();

                if (soda_rebool)
                {
                    Console.WriteLine("Soda needs to be restocked");
                }

                if (chips_rebool)
                {
                    Console.WriteLine("Chips need to be restocked");
                }

                if (candy_rebool)
                {
                    Console.WriteLine("Candy needs to be restocked");
                }
            }

            //If no products need to be restocked//
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nothing needs to be restocked!");
                Console.WriteLine();
            }

            //Ask user if they would like to keep using the restocking program//
            start_prog = "";
            while (start_prog.ToUpper() != "Y" && start_prog.ToUpper() != "N")
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue adjusting values?(Y or N): ");
                start_prog = Console.ReadLine();

                if (start_prog.ToUpper() == "Y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Great let's get back to it!");
                    Console.WriteLine();
                }
                else if (start_prog.ToUpper() == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    restocker = false;
                }
            }
        }
    }
}