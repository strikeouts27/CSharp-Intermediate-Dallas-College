/* 
Create an application class named PhotoDemo that demonstrates the methods of three related classes for a company that develops photographs.
Create a class named Photo that includes fields for width andheight in inches and properties for each field. The class should contain get and set accessors named Width and Height respectively.
Include a protected price field, and set it to $3.99 for an 8-inch by 10-inch photo, $5.99 for a 10-inch by 12-inch photo, and $9.99 for any other size (because custom cutting is required). The price field requires a get accessor but no set accessor.
Also include a ToString() method that returns a string constructed from the return value of the object’s GetType() method and the values of the fields.
Derive two subclasses— MattedPhoto and FramedPhoto.
The MattedPhoto class includes a string field named Color to hold a color, and the FramedPhoto class includes two string fields that hold the frame’s material (such as silver) and style (such as modern), named Material and Style respectively.
Use default, empty constructor.
The price for a MattedPhoto increases by $10 over its base cost, and the price for a FramedPhoto increases by $25 over its base cost. Each subclass should include a ToString() method that overrides the parent class version.

An example of the program is shown below:

Photo    8 X 10   Price: $3.99
Photo    8 X 9   Price: $9.99
MattedPhoto    white matting 10 X 12   Price: $15.99
FramedPhoto    modern, silver frame. 8 X 10   Price: $28.99

*/

using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace PhotoDemo
{
    public class PhotoDemo
    {

        static void Main()
        {
            // Write your code here
            Photo p = new Photo { width = 8, height = 10 };
            Console.WriteLine(p);

            Photo p2 = new Photo { width = 8, height = 9 };
            Console.WriteLine(p2); 

            MattedPhoto mp = new MattedPhoto { width = 10, height = 12, color = "white matting" };
            Console.WriteLine(mp);

            FramedPhoto f = new FramedPhoto { width = 8, height = 10, style = "Modern", material = "Silver"};
            Console.WriteLine(f);
        }
        public class Photo
        {
            public int width { get; set; }

            public int height { get; set; }

            protected double _price;
            protected double price
            {

                get
                {
                    if (width == 8 && height == 10) return 3.99;
                    else if (width == 10 && height == 12) return 5.99;
                    else return 9.99;
                }
            }

            public string DisplayPrice()
            {
                // Use en-US CultureInfo to ensure a leading $ and two decimals
                var ci = CultureInfo.GetCultureInfo("en-US");
                string priceStr = price.ToString("C2", ci);
                // Composite formatting with placeholders: {0}=type name, {1}=width, {2}=height, {3}=price
                return String.Format("{0} {1} X {2} Price: {3}", GetType().Name, width, height, priceStr);
            }

            public override string ToString()
            {
                var ci = CultureInfo.GetCultureInfo("en-US");
                string priceStr = price.ToString("C2", ci);
                return String.Format("{0} {1} X {2} Price: {3}", GetType().Name, width, height, priceStr);
            }
        }
        /* 
        Also include a ToString() method that returns a string constructed from the return value of the object’s GetType() method and the values of the fields.
        */


        // Derive two subclasses— MattedPhoto and FramedPhoto. 
        // The MattedPhoto class includes a string field named Color to hold a color, 

        // The price for a MattedPhoto increases by $10 over its base cost, and the price for a FramedPhoto increases by $25 over its base cost. 
        // Each subclass should include a ToString() method that overrides the parent class version.
            public class MattedPhoto : Photo
            {
                public string color { get; set; }


                public override string ToString()
                {
                    double total = base.price + 10.00;
                    var ci = CultureInfo.GetCultureInfo("en-US");
                    string priceStr = total.ToString("C2", ci);
                    return String.Format("{0} {1} {2} X {3} Price: {4}", GetType().Name, color, width, height, priceStr);
                }
            }

        // FramedPhoto class includes two string fields that hold the frame’s material (such as silver) and style (such as modern), named Material and Style respectively.

            public class FramedPhoto : Photo
            {
                public string material { get; set; }
                public string style { get; set; }

                public string color { get; set; }
                
                    public FramedPhoto()
                {
                material = "Silver";
                color = "silver"; 
                style = "Modern"; 
                }


                public double FramedPhotoPriceCalculation()
                {
                    double price = base.price + 25.00;
                    return price;
                }

                public override string ToString()
            {
                double price = FramedPhotoPriceCalculation();
                
                var ci = CultureInfo.GetCultureInfo("en-US");

                string priceStr = price.ToString("C2", ci);

                return String.Format("{0} {1} {2} X {3} Price: {4}", GetType().Name, color, width, height, priceStr);
            }
            }
    }
}