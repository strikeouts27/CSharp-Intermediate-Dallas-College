/* 
Exercise 10-3A

Create an application named JobDemo that declares and uses Job objects. The Job class holds job information for a home repair service. The class has five properties that include:

    JobNumber - The job number - int
    Customer - The customer name - string
    Description - The job description - string
    Hours - The estimated hours - double
    price - The price for the job

Create a constructor that requires parameters for all the data except price. Follow the order and data type above. Include auto-implemented properties for the job number, customer name, and job description, but not for hours or price; the price field value is calculated as estimated hours times $45.00 ($45.00 / hour) whenever the hours value is set.

Also create the following methods for theJob class:

    An Equals() method that determines two Jobs are equal if they have the same job number
    A GetHashCode() method that returns the job number
    A ToString() method that returns a string containing all job information in the following format:

Job 111 Smith exterior paint 20 hours @$45.00 per hour. Total price is $900.00

The JobDemo application declares a few Job objects, sets their values, and demonstrates that all the methods work as expected.

info> In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));

*/ 
using System;
using static System.Console;
using System.Globalization;
using System.Security.Cryptography;

namespace JobDemo
{
    class JobDemo
    {
        static void Main()
        {
            // public Job jobOne = new Job(jobNumber, customerName, jobDescription, jobHours);

            // My attempt at making objects 
            Job jobOne = new Job(1, "Cherry Painting", "Paint exterior of building", 10);
            Job jobTwo = new Job(1, "Apple Painting", "Paint the interior of the building", 11);
            Job jobThree = new Job(2, "Banna Painting", "Paint the Highschool Baseball Team Building", 12);
            Console.WriteLine(jobOne.Equals(jobTwo));
            Console.WriteLine(jobTwo.Equals(jobThree));
            Console.WriteLine("First hash code " + jobOne.GetHashCode());
            Console.WriteLine("Second hash code " + jobTwo.GetHashCode());
            Console.WriteLine(jobOne);
            Console.WriteLine(jobTwo);
            Console.WriteLine(jobThree); 
        }


        // Job Class
        public class Job
        {
            private double hourlyrate = 45.00;
            private double hours;
            private double totalPrice; 
            public double TotalPrice
            {
                get
                {
                    return totalPrice;
                }
                set {
                        { totalPrice = value; }
                    }
            }
                
            private int jobNumber { get; set; }
            private string customer { get; set; }
            private string description { get; set; }



            // An Equals() method that determines two Jobs are equal if they have the same job number
            public bool Equals(Job jobTwo)
            {
                if (this.jobNumber == jobTwo.jobNumber)
                {
                    return true;
                }
                return false;
            }
            
            public override int GetHashCode()
            {
                return this.jobNumber;
            }

            public double CalculateJobPrice(int price, int hours)
            {
                totalPrice = price * hours;
                return totalPrice;
            }
             
            // simple interpolation (uses the existing field/property names)
            public override string ToString()
            {
                return $"Job {jobNumber} {customer} {description} {hours} hours @{hourlyrate} per hour. Total price is {TotalPrice}.";
            }



            // create a constructor 
            public Job(int jobNumber, string customer, string description, double hours, double hourlyrate = 45.00)
            {
                this.jobNumber = jobNumber; 
                this.customer = customer;
                this.description = description;
                this.hourlyrate = hourlyrate;
                this.hours = hours;
                
                totalPrice = this.hours * this.hourlyrate; 
            }
        }
        
    }
}