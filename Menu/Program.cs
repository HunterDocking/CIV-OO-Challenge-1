using System;
using Shapes.Classes;
using Quadrilateral_Tests;
using Triangle_Tests;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Challenge 1 ~~~ Shapes Program");
                Console.WriteLine();
                Console.WriteLine("Choose what shape you would like to create:");
                Console.WriteLine("(1) Square");
                Console.WriteLine("(2) Rectangle");
                Console.WriteLine();
                Console.WriteLine();


                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.D1)
                {
                    try
                    {
                        Console.WriteLine("You chose SQUARE");
                        Console.WriteLine();
                        Console.WriteLine("Please pick a colour: ");
                        Console.WriteLine();
                        string userColour = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Please input the length: ");
                        Console.WriteLine();
                        int userS1 = int.Parse(Console.ReadLine());

                        if (userS1 < 1)
                        {
                            throw (new IntException(""));
                        }
                        Square userSquare = new Square(userColour, userS1);

                        Console.WriteLine();
                        Console.WriteLine("Your Square:");
                        Console.WriteLine("Colour: " + userSquare.Colour);
                        Console.WriteLine("Perimeter: " + userSquare.GetPerimeter());
                        Console.WriteLine("Area: " + userSquare.GetArea());
                        Console.WriteLine();
                        Console.WriteLine();
                    } catch (FormatException line)
                    {
                        Console.WriteLine("Incorrect format: " + line);
                    }
                    finally
                    {

                    }
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    try
                    {
                        Console.WriteLine("You chose RECTANGLE");
                        Console.WriteLine();
                        Console.WriteLine("Please pick a colour: ");
                        Console.WriteLine();
                        string userColour = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Please input the length: ");
                        Console.WriteLine();
                        int userS1 = int.Parse(Console.ReadLine());
                        if (userS1 < 1)
                        {
                            throw (new IntException(""));
                        }

                        Console.WriteLine();
                        Console.WriteLine("Please input the height: ");
                        Console.WriteLine();
                        int userS2 = int.Parse(Console.ReadLine());
                        if (userS2 < 1)
                        {
                            throw (new IntException(""));
                        }

                        Rectangle userRectangle = new Rectangle(userColour, userS1, userS2);

                        Console.WriteLine();
                        Console.WriteLine("Your Rectangle: ");
                        Console.WriteLine("Colour: " + userRectangle.Colour);
                        Console.WriteLine("Perimeter: " + userRectangle.GetPerimeter());
                        Console.WriteLine("Area: " + userRectangle.GetArea());
                        Console.WriteLine();
                        Console.WriteLine();
                    } catch (FormatException line)
                    {
                        Console.WriteLine("Incorrect format: " + line);
                    }
                    catch (IntException line)
                    {
                        Console.WriteLine("Number <1: "+ line);
                    }
                    finally
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Please choose a valid option");
                }
            }
        }
    }
}
