using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesandopereratorsetc
{
    class Program
    {
        static void Main(string[] args)
        {
            ////    //initalize new firstname variable
            ////    string firstName = "Mike";
            ////    //printing the value of firstName to console
            ////    Console.WriteLine(firstName);

            ////    //camel characters
            ////    string birthMonth = "June";
            ////    Console.WriteLine(birthMonth);

            ////    int birthMonth = 6;
            ////    Console.WriteLine(birthMonth);


            //    int age = 35;
            //string why = "because i said so";
            //char firstInital = 'L';

            //floating point types
            //float floatNumber = 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);

            //    double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);

            //    decimal decimalNumber = 2.164403304897294849383961032m;
            //    Console.WriteLine(decimalNumber);

            //Jessica is 23 years old.
            //sam is 47 .
            //Jessica is younger than sam

            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //int numberOfPeople = 4;
            //    double amountEach = 13.53d;
            //double totalBill = numberOfPeople * amountEach;
            //Console.WriteLine(totalBill);



            //Console.WriteLine("what is the name in the reservation?");
            //string reserveName = Console.ReadLine();

            //Console.WriteLine("How many people are in your party");

            //int numberofPeople = int.Parse(Console.ReadLine());
            //double amountEach = 13.53d;
            //double totalBill = numberofPeople * amountEach;
            //Console.WriteLine("Reservation: " + reserveName);
            //Console.WriteLine("totaldue: $" + totalBill);

            //int priceofDiapers = 8;



            Console.WriteLine("Welcome to you Donation Tracker!");
            Console.WriteLine("Please enter the info below as promted");

          
            Console.WriteLine("How many ones?");
            int ones = int.Parse(Console.ReadLine());
             int onesInDollars = ones * 1;

            Console.WriteLine("How many fives?");
            int fives = int.Parse(Console.ReadLine());
            int fivesInDollars = fives * 5;

            Console.WriteLine("How many tens?");
            int tens = int.Parse(Console.ReadLine());
            int tensInDollars = tens * 10;

            Console.WriteLine("How many twenties?");
            int twenties = int.Parse(Console.ReadLine());
            int twentiesInDollars = twenties * 20;

            Console.WriteLine("How many fifties?");
            int fifties = int.Parse(Console.ReadLine());
            int fiftiesInDollars = fifties * 50;

            Console.WriteLine("How many Hundreds?");
            int hundreds = int.Parse(Console.ReadLine());
            int hundredsInDollars = hundreds * 100;

            Console.WriteLine("How many quarters?");
            int quarters = int.Parse(Console.ReadLine());
            double quartersInDollars = quarters * .25d;


            //print personal info and donation amount and year

            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();

            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            //print personal info
            Console.WriteLine("Your name is " + yourname);
            
            Console.WriteLine("Your Address is " + address);
            
            Console.WriteLine("Your email address is " + email);
            
            Console.WriteLine("What fiscal year did you donate?");
            string fiscalyear = Console.ReadLine();
            //donation amount

            double donationAmount = (onesInDollars + fivesInDollars + tensInDollars + twentiesInDollars + fiftiesInDollars + hundredsInDollars + quartersInDollars);
            Console.WriteLine("Your Donation amount is $ + donation amount");

            Console.WriteLine("Thank you for your donation.");



        }
    }
}
