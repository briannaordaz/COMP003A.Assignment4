// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {



        //initialization and declaration of variables
        int choice;
        int counter = 0;
        
        Console.Write("1. Start/continue Routine\n2. View Progress\n3. Exit");
        
        do // do-while loop is used here to continue looping the prompt if the condition is true. each time the user chooses 1, 2, or 3 it will display a message or end the loop. 
        {
           
            Console.WriteLine("\nEnter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) // an if-statement for when the user chooses option 1 (Start)
            {
                
                counter++; //this will increment the routine by one, so each time the user chooses option one it will increment and track progress
               

                if (counter == 3) //This displays a message saying "step 3 is restricted and skipped"
                {
                  
                    Console.WriteLine($"Step {counter} is restricted and was skipped.");
                    
                }
                else if (counter >= 5) // This prevents the user from exceeding the number of routine steps allowed
                {
                    Console.WriteLine("Safety limit reached. Routine stopped.");
                    
                }
                else //this displays a message each time a routine step is completed
                {
                    Console.WriteLine($"Routine {counter} Completed!!");
                }
                
                
                
            }
            else if (choice == 2)  //If the user chooses option 2 (View Progress), it will allow the user to view their routine progress
            {
                Console.WriteLine($"Current Progress: {counter} steps completed!");
            }
            else if (choice == 3) //If the user chooses option 3 (Exit) then the code will display a message saying "Goodbye!" and break/exit the loop
            {
                Console.WriteLine("Goodbye!!");
                break; //this will break/exit the loop
            }
            else //if the user types any number that's not in the menu then the console will display "invalid choice"
            {
                Console.WriteLine("Invalid choice.");
            }
            
        }
        while (true); // this allows the prompt to keep looping until the user chooses to exit

        
        
        
        
        
        
        
        
    }
}


 
