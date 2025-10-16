//Program 1
//CIS 199-50
//Due date: 9/26/2024
//By: Helen Le

//This program is a price quote calculator that asks the user 
//to enter information about car repair needs
// and outputs the total cost for the job.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declares constant rates
            const double CONSULTATION_FEE = 100.00; //Fixed $100 consultation fee
            const double LABOR_CHARGE_PER_HOUR = 75.00; //Labor charge is $75 per hour
            const double SENIOR_DISCOUNT = 0.10; //Senior discount rate is 10%

            Console.WriteLine("Welcome to Smiths Auto Repair!");
            Console.WriteLine("*******************************");

            //Asks user for input
            Console.Write("Client's name: ");
            string clientName = Console.ReadLine(); //Name of client

            Console.Write("Car type: ");
            string carType = Console.ReadLine(); //Type of car

            Console.Write("Work hours: ");
            int workHours = int.Parse(Console.ReadLine()); //Hours it will take to work on car

            Console.Write("Parts cost: ");
            double partsCost = double.Parse(Console.ReadLine()); //Cost of parts needed for repair

            Console.Write("Staff assigned: ");
            int staffAssigned = int.Parse(Console.ReadLine()); //Number of staff assigned to car repair

            Console.Write("Senior citizen? (1 or 0): ");
            int isSeniorCitizen = int.Parse(Console.ReadLine()); //Whether or not user is a senior citizen

            //Calculates total cost
            double totalCost = CONSULTATION_FEE + (LABOR_CHARGE_PER_HOUR * workHours * staffAssigned) + partsCost; //Calculates cost before discount
            totalCost = totalCost - (totalCost * SENIOR_DISCOUNT * isSeniorCitizen); //Applies senior discount

            //Displays total cost
            Console.WriteLine($"Total Cost: ${totalCost:F2}");
            Console.WriteLine("*******************************");


        }
    }
}
