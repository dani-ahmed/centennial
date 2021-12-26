using System;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

public class Class1
{   
    //PROGRAM 3 CONSTANTS
    public const int DomesticCost = 325;
    public const int InternationalCost = 1375;

    //PROGRAM 5 CONSTANT
    public const int Pine = 100;
    public const int Oak = 225;
    public const int Mahogany = 310;

    public Class1()
    {

        //PROGRAM 1
        Console.WriteLine("Pick a number betweeen 1-3, and 0 to exit.");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Calculate area");
                break;
            case 2:
                Console.WriteLine("Calculate volume");
                break;
            case 3:
                Console.WriteLine("Calculate surface area");
                break;
            case 0:
                Console.WriteLine("Exit the program");
                break;
            default:
                Console.WriteLine("ERROR:Invalid choice");
                break;
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 2
        Console.WriteLine("Enter first integer");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer");
        int int2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a character");
        char c = Convert.ToChar(Console.Read());
        int result;
        switch (c)
        {
            case 'a':
            case 'A':
                result = int1 + int2;
                break;
            case 's':
            case 's':
                result = int1 - int2;
                break;
            default:
                result = int1 * int2;
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 3
        Console.WriteLine("What is your residency status?");
        string status = Console.ReadLine();
        Console.WriteLine("How many courses are you taking?");
        int courses = Convert.ToInt32(Console.RaadLine());
        string status2 = status.ToLower();
        int total;
        if (status2 == "domestic")
        {
            total = courses * DomesticCost;
        }
        else if (status2 == "international")
        {
            total = courses * InternationalCost;
        }
        else
        {
            Console.WriteLine("Invalid answer");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 4
        Console.WriteLine("Enter a day of the week: ");
        string day = Console.ReadLine();
        string day2 = day.ToLower();

        if (day2 == "sun" || day2 == "sunday")
        {
            Console.WriteLine("Home");
        }
        else if (day2 == "mon" || day2 == "monday) ;
        {
            Console.WriteLine("Work");
        }
        else if (day2 == "tue" || day2 == "tuesday")
        {
            Console.WriteLine("Work");
        }
        else if (day2 == "wed" || day2 == "wednesday")
        {
            Console.WriteLine("Home");
        }
        else if (day2 == "thurs" || day2 == "thursday" || day2 == "thu")
        {
            Console.WriteLine("Work");
        }
        else if (day2 == "fri" || day2 == "friday")
        {
            Console.WriteLine("Work");
        }
        else if (day2 == "sat" || day2 == "saturday")
        {
            Console.WriteLine("Work");
        }
        else
        {
            Console.WriteLine("Invalid.");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 5

        Console.WriteLine("Choose Pine, Oak, or Mahogany: ");
        string wood = Console.ReadLine();
        string wood2 = wood.ToLower();
        switch (wood2)
        {
            case "pine":
                Console.WriteLine("C", Pine);
                break;
            case "oak":
                Console.WriteLine("C", Oak);
                break;
            case "mahogany":
                Console.WriteLine("C", Mahogany);
                break;
            default:
                Console.WriteLine("Invalid");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 6
        Console.WriteLine("Enter a value for a: ");
        double a = Console.ReadLine();
        Console.WriteLine("Enter a value for b: ");
        double b = Console.ReadLine();
        Console.WriteLine("Enter a value for c: ");
        double c = Console.ReadLine();

        if (a == 0)
        {
            Console.WriteLine("Invalid input for a");
        }
        else
        {
            double p = -b / 2 * a;
            double d = b ^ 2 - 4 * a * c;
            if (d >= 0)
            {
                double q = Math.Sqrt(d) / 2 * a;
                Console.WriteLine(p + q);
                Console.WriteLine(p - q);
            }
            else if (d < 0)
            {
                double q = Math.Sqrt(-d) / 2 * a;
                Console.WriteLine(p + q);
                Console.WriteLine(p - q);
            }
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 7
        Console.WriteLine("Enter hourly rate: ");
        double pay = Convert.ToDouble(Console.ReadLine());
        if (double < 5.65)
        {
            Console.WriteLine("Error");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 8
        Console.WriteLine("Enter hourly rate: ");
        double pay2 = Convert.ToDouble(Console.ReadLine());
        if (pay2 < 5.65 || pay2 > 49.99)
        {
            Console.WriteLine("Error");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 9
        Console.WriteLine("Enter hourly rate: ");
        double pay3 = 0;
        int check = 0;
        while (check < 2)
        {
            pay3 = Convert.ToDouble(Console.ReadLine());
            if (pay3 > 49.99 || pay3 < 5.65)
            {
                Console.WriteLine("Error, try again");
                check++
            }
            else if (check == 1)
            {
                Console.WriteLine("Error");
                check++
            }
            else
            {
                Console.WriteLine("C", pay3);
                Console.WriteLine("C", pay3 * 40);
                check = 2;
            }
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 10
        Console.WriteLine("Enter your Grade Point Average(GPA): ");
        double gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your admission test score: ");
        int admission = Convert.ToInt32(Console.ReadLine());

        if (gpa >= 3 && admission >= 60 || gpa < 3 && admission >= 80)
        {
            Console.WriteLine("Accept");
        }
        else
        {
            Console.WriteLine("Reject");
        }
        //---------------------------------------------------------------------------------
        //PROGRAM 11
        Console.WriteLine("Enter your hourly rate: ");
        double payrate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter hours worked: ");
        double hours = Convert.ToDouble(Console.ReadLine);
        double grosspay = payrate * hours;
        double tax;
        if (grosspay > 300)
        {
            tax = 0.12;
        }
        else if (grosspay <= 300)
        {
            tax = 0.1;
        }
        double taxamount = grosspay * tax;
        double netpay = grosspay - taxamount;
        //---------------------------------------------------------------------------------
        //PROGRAM12
        Console.WriteLine("Lawn-mowing application: ");
        Console.WriteLine("Enter your lawn's length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your lawn's width");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = width * length;
        double weeklyFee;
        if (area < 400)
        {
            weeklyFee = 25;
        }
        else if (area >= 400 && area < 600)
        {
            weeklyFee = 35;
        }
        else if (area >= 600)
        {
            weeklyFee = 50;
        }
        Console.Write("The weekly fee is: ")
        Console.WriteLine("C", weeklyFee);
        double seasonalFee = weeklyFee * 20;
        Console.Write("The total fee for the 20-week season is: ");
        Console.WriteLine("C", seasonalFee);

        Console.WriteLine("Do you want to pay (1)once, (2)twice, or (3)20 times per year: ");
        int timesPaid = Convert.ToInt32(Console.ReadLine());

        switch(timesPaid)
        {
            case 1:
                Console.Write("You chose to pay once per season, totalling ");
                Console.WriteLine("C", seasonalFee);
                break;
            case 2:
                Console.Write("You chose to pay twice for the season, each payment being ");
                double twiceFee = seasonalFee / 2 + 5;
                Console.WriteLine("C", twiceFee);
                Console.Write("The total for the season will be:  ");
                Console.WriteLine("C", twiceFee * 2);
                break;
            case 3;
                Console.Write("You chose to pay 20 times, each payment being ");
                double threeFee = seasonalFee / 20 + 3;
                Console.WriteLine("C", threeFee);
                Console.Write("The total for the season will be ");
                Console.WriteLine("C", threeFee * 20);
        }


    }
}
