using System;
using static System.Console;
using System.Globalization;

namespace JobDemo3
{
    class JobDemo3
    {
        static void Main()
		{
			// Write your code here
			Job[] jobs = new Job[5];

			for (int i = 0; i < jobs.Length; i++)
			{
				var newJob = new Job().CreateJob();
				jobs[i] = newJob;
			}
			


        }

        // Job Class 
        public class Job
        {
            private int jobNumber = 0;
            private string customerName;
            private string description;
            private int jobHours;
            private double price;
            public int CreateJobNumber(int jobNumber)
            {
                this.jobNumber++;

                return jobNumber;
            }
            public int JobNumber { get; set; }
            public string CustomerName { get; set; }
            public string Description { get; set; }
            public int JobHours { get; set; }
            public double Price { get; set; }

            // I want to create an array that is empty and can hold different data types. 
            // I than want to create a series of prompts for the user to input the values into variables. 
            // I than want the array to have those values be assigned in the designated slots. 

            public Job CreateJob()
            {
                var job = new Job();

                Console.Write("Enter job number: ");
                if (int.TryParse(Console.ReadLine(), out int num)) job.jobNumber = num;

                Console.Write("Enter customer name: ");
                job.customerName = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter description: ");
                job.description = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter estimated hours: ");
                if (int.TryParse(Console.ReadLine(), out int hours)) job.jobHours = hours;

                Console.Write("Enter price: ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.CurrentCulture, out double p)) job.price = p;

                return job;
            }

        }
        

        // RushJob Class 
        public class RushJob : Job
        {
            private double premiumFee = 150.00;


            // preimum calculation 
        }

    }
}