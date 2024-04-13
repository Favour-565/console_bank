using SQ20.Net_Week5_Task.Accountepo;
using SQ20.Net_Week5_Task.CustomerRepo;
using SQ20.Net_Week5_Task.Model;
using SQ20.Net_Week5_Task.Model.Customer;

namespace SQ20.Net_Week5_Task
{
    public class Dashboard
    {
        public static void displayDashboard(Customer customer)
        {
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("   MY DASHBOARD");
            Console.WriteLine("|--------------------------------------------|");

            Console.WriteLine();

            Console.WriteLine("TO GET STARTED PRESS 1 TO CREATE ACCOUNT, 2 TO DEPOSIT, 3 TRANSFER,  4  FOR WITHDRAWAL, 5 FOR ACCOUNT BALANCE, 6 FOR ACCOUNT STATEMENT, 7 FOR ACCOUNT DETAILS");
            Console.Write("ENTER INPUT: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Accountepo.AccountService.CreateAccount(customer);

            }
            if (input == "2")
            {
                AccountService.DepositIntoAccount(customer);
            }


            if (input == "3")
            {
                AccountService.Transfer(customer);
            }

            if (input == "4")
            {
                AccountService.WithdrawFromAccount(customer);
            }

            if (input == "5")
            {
                AccountService.GetAccountBalance(customer);
            }

            if (input == "6")
            {
                AccountService.GetAccountStatement(customer);
            }

            if (input == "7")
            {
                AccountService.GetAccountDetails(customer);
            }




        }


    }
}
