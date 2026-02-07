// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {




        int choice;
        int counter = 0;
        Console.Write("1. Start/continue Routine\n2. View Progress\n3. Exit");
        
        do
        {
           
            Console.WriteLine("\nEnter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                
                counter++;
                Console.WriteLine($"Routine {counter} Completed!!");

                if (counter == 3)
                {
                    Console.WriteLine($"Step {counter} is restricted and was skipped.");
                    
                }


                if (counter >= 5)
                {
                    Console.WriteLine("Safety limit reached. Routine stopped.");
                    break;
                }
                
                
                
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Current Progress: {counter} steps completed!");
            }

            
            
        }
        while (choice == 1 || choice == 2);


        
        
        
        
        
        
        
    }
}


 
