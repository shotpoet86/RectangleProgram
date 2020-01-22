/*Programmer: Austin Parker
 * Date: Jan. 22nd, 2020
 Purpose: This program is used to calculate and 
 display area and perimeter of given rectangle.
 */

using System;

using static System.Console;
using static System.Math;

namespace Rectangle
{
    class Rectangle
    {

        static void Main()
        {
            /*Declared variables*/
            double height,
                width,
               rectangleArea,
                rectanglePerimeter;
            DisplayInstructions();

            /*Declares the methods that will be called by the variables*/
            height = GetDimension("Height");
            width = GetDimension("Width");
            rectangleArea = CalculateArea(height, width);
            rectanglePerimeter = CalculatePerimeter(height, width);
            DisplayResults(rectangleArea, rectanglePerimeter);
            ReadKey();
        }

        /*Displays the instructions to the user how to use the program*/
        static void DisplayInstructions()
        {
            Write("Welcome to the rectangle calculation program!");
            Write("\nThis program allows calculation of area and perimeter for given rectangle.\n" + 
                "You will first be asked to enter the Height of the rectangle followed by Width.\n" + 
                "Feel free to enter the values in single integer form or decimal form, whichever you prefer.\n");
            WriteLine("\nPlease press any key to initiate the program.");
           
            ReadKey();
            Clear();
        }

        /*This method asks for the user input for dimensions of rectangle and will Parse the string to a Double*/
        static double GetDimension(string shapes)
        {
            string inputValue;
            double rectangleTotal;
            Write("Enter total {0} of triangle : ", shapes);
            inputValue = ReadLine();
            rectangleTotal = double.Parse(inputValue);
            return rectangleTotal;
        }

        /*Formula to calculate Area*/
        static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        /*Formula to calculate Perimeter*/
        static double CalculatePerimeter(double height, double width)
        {
            return (height * width) / 2;
        }

        /*Clears previous info, displays end results, aligns values allowing readability, and exits program*/
        static void DisplayResults(double rectangleArea, double rectanglePerimeter)
        {
            Clear();
            WriteLine("     Area of the rectangle = {0,10:F1}", rectangleArea);
            WriteLine("     Perimeter of the rectangle = {0,5:F1}", rectanglePerimeter);
            WriteLine("\nPress any key to end program");
        }

    }
}
