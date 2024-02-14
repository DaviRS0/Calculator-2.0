/* Calculator
 * Purpose of program: To calculate the monthly subscription fee for a service based on the user's age, the month they are registering, and if they were referred by a client.
 *
 * Revision History: Davi Sobral, 2024.02.13 
 */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();
        int age;
        double fee = 0;
        double discount = 0;
        double referralDiscount = 0;
        double subtotal = 0;
        double hst = 0;
        double cityTax = 0;
        double finalFee = 0;
        string separator = "--------------------------------------------------------\n";


        if (int.TryParse(input, out age))
        {
            if (age <= 19)
            {
                fee = 10.00;
            }
            else if (age >= 20 && age <= 29)
            {
                fee = 25.50;
            }
            else if (age >= 30 && age <= 59)
            {
                fee = 50.50;
            }
            else if (age >= 60)
            {
                fee = 0;
            }

            Console.Write("Please enter the start month: ");
            string month = Console.ReadLine().ToLower();

            if (month == "january" || month == "february")
            {
                discount = -10.00;
            }
            else if (month == "march" || month == "april")
            {
                discount = fee * -0.10;
            }
            else if (month == "may")
            {
                discount = 20.00;
            }

            Console.Write("Were you referred by a client? (yes/no):  \n");
            string referral = Console.ReadLine().ToLower();

            if (referral == "yes")
            {
                referralDiscount = -10.50;
                
            }

            subtotal = fee + discount + referralDiscount;
            if (subtotal < 0)
            {
                subtotal = 0;
            }

            hst = subtotal * 0.13;
            cityTax = subtotal * 0.08;
            finalFee = subtotal + hst + cityTax;

            Console.WriteLine($"{separator}");

            Console.WriteLine($"Your age: {age}");
            Console.WriteLine($"Your registration month: {month} \n");

            Console.WriteLine($"{separator}");
            Console.WriteLine($"Monthly subscription based on age: {fee:C}");
            Console.WriteLine($"Start Month Adjustment: {discount:C}");
            Console.WriteLine($"Client referral adjustment: {referralDiscount:C}");
            Console.WriteLine($"Subtotal: {subtotal:C}\n");

            Console.WriteLine($"{separator}");
            Console.WriteLine($"HST: {hst:C}");
            Console.WriteLine($"City Services Tax: {cityTax:C}\n");

            Console.WriteLine($"{separator}");

            Console.WriteLine($"Final Monthly Subscription Total: {finalFee:C}\n");

            Console.WriteLine($"{separator}");
        }
    }
}