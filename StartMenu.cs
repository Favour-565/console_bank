using SQ20.Net_Week5_Task.CustomerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week5_Task
{
    public class StartMenu
    {
       public static void Authenticate()
        {
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("WELCOME TO EZEH'S BANK");
            Console.WriteLine("|--------------------------------------------|");

            Console.WriteLine();

            Console.WriteLine("TO GET STARTED PRESS 1 TO REGISTER OR 2 TO LOGIN");
            Console.Write("ENTER INPUT: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                CustomerService.Register();
            }
            else
            {
                CustomerService.Login();
            }
            
        }

    }
}
