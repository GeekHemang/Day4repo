using ConsoleEncapsulationViolation.Domain;
using System.Threading.Channels;
using System;

namespace ConsoleEncapsulationViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle();
            R1.width = 1000;
            R1.height = -100;
            R1.color = "Green";
            //Printinfo (R1 );
            Printinfo(R1, "Small");


            Rectangle R2 = new Rectangle(); 
            R2.width = 1000;
            R2.height = -100;
            R2.color = "red";
            //Printinfo (R2 );
            Printinfo(R2, "Big");

            Console.WriteLine("End of Line.");
            
        }
        static void Printinfo(Rectangle r)
        {
            Console.WriteLine("Width of rectangle is:" + r.width);
            Console.WriteLine("Heigth of rectangle is:" + r.height);
            Console.WriteLine("Color of rectangle is:" + r.color);
            Console.WriteLine("Area of rectangle is:" + r.CalculatedArea());
            Console.WriteLine();
        }

        static void Printinfo(Rectangle r,string details )
        {
            Console.WriteLine("Details of Rectangle " + details);
            Printinfo (r);
        }
        
       
    }
    
}
