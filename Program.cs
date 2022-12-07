/*start with total money
#ask the user if they have more bills
#if they do have more bills, continue asking how much each bill is
#subtract the total of all bills from the total money
#ask if they are going to save any money
#subtract any savings from the total money
#present the total money, savings and bills*/
using System;

class Bills
{
    static void Main()
    {
        double starting_money = 512.71;
        Console.WriteLine("Do you have any bills?");
        string userResponse = Console.ReadLine();
        if (userResponse == "yes")
        {
            var bills = new List<double>();
            while (true)
            {
                Console.WriteLine("Bill amount:");
                bills.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Do you have another bill?");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }
            }  
        
            Console.WriteLine("Will you be saving anything this month?");
            string save_answer = (Console.ReadLine());
            double savings = 0;
            if (save_answer.ToLower() == "yes")
            {
                Console.WriteLine("How much are you saving this month?");
                savings = (Convert.ToInt32(Console.ReadLine()));
            }
            double bill_total = bills.Sum();
            double final_total = starting_money - bill_total - savings;

            Console.WriteLine($"Your bills come to £{Math.Round(bill_total, 2)}");
            Console.WriteLine($"Your savings come to £{Math.Round(savings, 2)}");
            Console.WriteLine($"Your spending money comes to £{Math.Round(final_total, 2)}");
        } 
        else 
        {
            Console.WriteLine("What do you mean you don't have bills?");
        }
    }
}