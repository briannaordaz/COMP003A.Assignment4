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
                

                
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Progress:\n{counter} routines completed!");
            }

            
            
        }
        while (choice == 1 || choice == 2);

        
        
        
        
        
        
        
        
    }
}


 
