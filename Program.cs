/*start with total money
ask the user if they have more bills
if they do have more bills, continue asking how much each bill is
subtract the total of all bills from the total money
ask if they are going to save any money
subtract any savings from the total money
present the total money, savings and bills*/
using System;
class Bills
{
    static void Main()
    {
        float starting_money = 512.71f;

        //asks user how many bills they have and converts their response to Int32
        Console.WriteLine("How many bills do you have?");
        int userResponse = (Convert.ToInt32(Console.ReadLine()));

        /*creates a new list of floats and asks the user how much each individual bill costs
        and adding it to the list each time the user inputs a number*/
        var bills = new List<float>();
        for (int i = 0; i < userResponse; i++)
        {
            Console.WriteLine($"Bill #{i + 1}: ");
            bills.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Will you be saving anything this month?");
        float savings = Convert.ToInt32(Console.ReadLine());
        
        float bill_total = bills.Sum();
        float final_total = starting_money - bill_total - savings;

        Console.WriteLine($"Your bills come to £{Math.Round(bill_total, 2)}");
        Console.WriteLine($"Your savings come to £{Math.Round(savings, 2)}");
        Console.WriteLine($"Your spending money comes to £{Math.Round(final_total, 2)}");
    } 
}
