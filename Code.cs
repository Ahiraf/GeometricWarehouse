using System;

namespace Labworks
{
    // Class representing a Circle
    class Circle
    {
        public int Id {get;set;}  // Property to hold the ID of the Circle
        public float Diameter {get;set;}  // Property to hold the diameter of the Circle
        
        // Constructor to initialize a Circle with an ID and Diameter
        public Circle(int id,float diameter)
        {
            Id = id;
            Diameter = diameter;
        }

        // Method to calculate the area of the Circle
        public float Area()
        {
            float radius = Diameter/2;
            return (float)3.1416*radius*radius;
        }
        public void Display()
        {
            Console.WriteLine(Id + "\tCircle\t\tDiameter: " + Diameter);
        }
    }

    // Class representing a Rectangle
    class Rectangle
    {
        public int Id {get;set;}  // Property to hold the ID of the Rectangle
        public float Height {get;set;}  // Property to hold the height of the Rectangle
        public float Width {get;set;}  // Property to hold the width of the Rectangle

        // Constructor to initialize a Rectangle with an ID, Height, and Width
        public Rectangle(int id,float height,float width)
        {
            Id = id;
            Height = height;
            Width = width;
        }

        // Method to calculate the area of the Rectangle
        public float Area()
        {
            return Height*Width;
        }
        public void Display()
        {
            Console.WriteLine(Id + "\tRectangle\tHeight: " + Height + ", Width: " + Width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Arrays to store circles and rectangles
            Circle[] circles = new Circle[100];
            Rectangle[] rectangles = new Rectangle[100];
            int circleCount = 0;  // Counter to keep track of the number of circles
            int rectangleCount = 0;  // Counter to keep track of the number of rectangles
            int idCounter = 1;  // Counter for generating unique IDs for shapes

            while (true)
            {
                // Menu options
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine("1) Add a circle");
                Console.WriteLine("2) Add a rectangle");
                Console.WriteLine("3) List items");
                Console.WriteLine("4) Get statistics");
                Console.WriteLine("5) Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());  // To Read user choice

                if (choice == 1)
                {
                    // Adding a circles
                    Console.Write("Enter the diameter of the circle: ");
                    float diameter = float.Parse(Console.ReadLine());
                    circles[circleCount++] = new Circle(idCounter++, diameter);
                }
                else if (choice == 2)
                {
                    // Adding a rectangles
                    Console.Write("Enter the height of the rectangle: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    float width = float.Parse(Console.ReadLine());
                    rectangles[rectangleCount++] = new Rectangle(idCounter++, height, width);
                }
                else if (choice == 3)
                {
                    // Listing all shapes
                    Console.WriteLine("Id\tType\t\tDimensions");
                    Console.WriteLine("=================================================");
                    
                   int circleIndex = 0;
                    int rectangleIndex = 0;

                    // Iterating while there are circles or rectangles left to print
                    while (circleIndex < circleCount || rectangleIndex < rectangleCount)
                    {
                        if (circleIndex < circleCount && (rectangleIndex >= rectangleCount || circles[circleIndex].Id < rectangles[rectangleIndex].Id))
                        {
                            //To print the circle if its ID is smaller or if there are no rectangles left
                            circles[circleIndex++].Display();
                        }
                        else if (rectangleIndex < rectangleCount)
                        {
                            // To print the rectangle if its ID is smaller or if there are no circles left
                            rectangles[rectangleIndex++].Display();
                        }
                    }
                }
                else if (choice == 4)
                {
                    // Showing statistics
                    int totalShapes = circleCount + rectangleCount;
                    Console.WriteLine("Total shapes: " + totalShapes);
                    Console.WriteLine("Total number of circles: " + circleCount);
                    Console.WriteLine("Total number of rectangles: " + rectangleCount);

                    float totalCircleArea = 0;
                    float totalRectangleArea = 0;

                    // Calculate total area occupied by circles
                    for (int i=0;i<circleCount;i++)
                    {
                        totalCircleArea += circles[i].Area();
                    }

                    // For calculating total area occupied by rectangles
                    for (int i=0;i<rectangleCount;i++)
                    {
                        totalRectangleArea += rectangles[i].Area();
                    }

                    float totalArea = totalCircleArea+totalRectangleArea;
                    Console.WriteLine("Total area: " + totalArea);

                    if (totalArea > 0)
                    {
                        // Showing area percentage for circles and rectangles
                        Console.WriteLine("The total area occupied by circles: " + totalCircleArea + " (" + (totalCircleArea / totalArea * 100).ToString("0.00") + "%)");
                        Console.WriteLine("The total area occupied by rectangles: " + totalRectangleArea + " (" + (totalRectangleArea / totalArea * 100).ToString("0.00") + "%)");
                    }
                }
              
              /* Here ToString("0.00") converts a value into its string representation. It is like fixed << serprecision(2) in c++. 
              Here "0" ensures at least one digit is displayed before the decimal point and ".00" ensures two digits are displayed after the decimal point. */
              
                else if (choice == 5)
                {
                    // To exit the program
                    Console.WriteLine("Exiting the Program.............");
                    break;
                }
                else
                {
                    // Invalid choice entered
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}
