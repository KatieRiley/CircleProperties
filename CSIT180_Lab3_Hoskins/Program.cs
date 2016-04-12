/*
*  Kathryn Hoskins
*  CSIT180 Lab3
*
*   Write a console program that uses a Circle class to calculate a circles area, diameter and circumference given the circles radius
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIT180_Lab3_Hoskins
{

    class Program
    {
        static void Main(string[] args)
        {
            double theRadius = 0;
            Circle myCircle;
            Console.Write("What is the radius of the circle you want to create?: ");
            theRadius = Convert.ToDouble(Console.ReadLine());

            //initiating myCircle with the radius that the user entered
            myCircle = new Circle(theRadius);


            Console.WriteLine();

            //calling the methods inside of the writeline()
            //using the format {0:n} so that it will write to the screen as a real number, where it will add a ',' after the hundreds place and 
            //  show 2 digits after the decimal place
            Console.WriteLine("The area of your circle is {0:f2}", myCircle.getArea());
            Console.WriteLine("The diameter of your circle is {0:n}", myCircle.getDiameter());
            Console.WriteLine("The circumference of your circle is {0:n}", myCircle.getCircumference());

            //using console.readLine() to keep the console window open
            Console.ReadLine();

        }
    }

    public class Circle {

        private const double PI = 3.14159;
        private double myRadius;

        /* public Circle()
        *  Defalt constructor
        *   Parameters: NONE
        *   sets: myRadius = 0.0
        */
        public Circle()
        {
            myRadius = 0.0;
        }
        
        /* public Circle(double newRadius)
        *  constructor
        *   Parameters: double (newRadius) - the value you wish to use as the radius for  the circle
        *   sets: myRadius = newRadius
        */
        public Circle(double newRadius)
        {
            myRadius = newRadius;
        }

        /* public double getArea()
        *  returns the area of the circle by multiplying PI * myRadius * myRadius
        *   Parameters: NONE
        *   returns: double (theArea)
        */
        public double getArea()
        {
            return PI * myRadius * myRadius;
        }

        /* public double getDiameter()
        *  returns the diameter of the circle by multiplying myRadius * 2
        *   Parameters: NONE
        *   returns: double (theDiameter)
        */
        public double getDiameter()
        {
            return myRadius * 2;
        }

        /* public double getCircumference()
        *  returns the circumference of the circle by multiplying 2 * PI * myRadius
        *   Parameters: NONE
        *   returns: double (theCircumference)
        */
        public double getCircumference()
        {
            return 2 * PI * myRadius;
        }
    }
}
