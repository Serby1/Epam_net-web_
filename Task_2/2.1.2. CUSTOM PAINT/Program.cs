using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Program
    {
        public static Line CreateLine()
        {
            double bigenX, bigenY, endX, endY;
            Console.WriteLine("\nEnter the coordinates of the starting point");
            Console.Write("X: ");
            bigenX = double.Parse(Console.ReadLine());
            Console.Write("\nY: ");
            bigenY = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the coordinates of the finaling point");
            Console.Write("X: ");
            endX = double.Parse(Console.ReadLine());
            Console.Write("\nY: ");
            endY = double.Parse(Console.ReadLine());
            return new Line(bigenX, bigenY, endX, endY);
        }

        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            int value = -1;
            while (value != 0)
            {
                Console.WriteLine("Select a command:" +
                    "\n1.Create new figure" +
                    "\n2.Show all figures" +
                    "\n3.Delete all figures" +
                    "\n4.EXIT\n");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out value);
                if (result)
                { }
                else
                {
                    Console.WriteLine("Invalid value entered\n");
                    value = -1;
                }
                switch (value)
                {
                    case -1:
                        break;
                    case 1:
                        {
                            Console.WriteLine("\nSelect a figure:" +
                            "\n1.Line" +
                            "\n2.Circle" +
                            "\n3.Ring" +
                            "\n4.Rectangle" +
                            "\n5.Square" +
                            "\n6.Triangle\n");
                            input = Console.ReadLine();
                            result = int.TryParse(input, out value);
                            if (result)
                            { }
                            else
                            {
                                Console.WriteLine("Invalid value entered\n");
                                value = -1;
                            }
                            switch (value)
                            {
                                case -1:
                                    break;
                                case 1:
                                    {
                                        Figure line = CreateLine();
                                        figures.Add(line);
                                        Console.WriteLine("\nFigure LINE added!\n");
                                    }
                                    break;
                                case 2:
                                    {
                                        double centerX, centerY, radius;
                                        Console.WriteLine("\nCircle:\n" +
                                            "Enter the center coordinates");
                                        Console.Write("X: ");
                                        centerX = double.Parse(Console.ReadLine());
                                        Console.Write("\nY: ");
                                        centerY = double.Parse(Console.ReadLine());
                                        Console.Write("\nEnter radius: ");
                                        radius = double.Parse(Console.ReadLine());
                                        if (radius < 0)
                                        {
                                            Console.WriteLine("Invalid value\n");
                                            break;
                                        }
                                        Figure circle = new Circle(centerX,centerY,radius);
                                        figures.Add(circle);
                                        Console.WriteLine("\nFigure CIRCLE added!\n");
                                    }
                                    break;
                                case 3:
                                    {
                                        double centerX, centerY, nouterRadius, innerRadius;
                                        Console.WriteLine("\nRing:\n" +
                                            "Enter the center coordinates");
                                        Console.Write("X: ");
                                        centerX = double.Parse(Console.ReadLine());
                                        Console.Write("\nY: ");
                                        centerY = double.Parse(Console.ReadLine());
                                        Console.Write("\nEnter nouter radius: ");
                                        nouterRadius = double.Parse(Console.ReadLine());
                                        if (nouterRadius < 0)
                                        {
                                            Console.WriteLine("Invalid value\n");
                                            break;
                                        }
                                        Console.Write("Enter inner radius: ");
                                        innerRadius = double.Parse(Console.ReadLine());
                                        if (innerRadius < 0)
                                        {
                                            Console.WriteLine("Invalid value\n");
                                            break;
                                        }
                                        Figure ring = new Ring(centerX, centerY, nouterRadius, innerRadius);
                                        figures.Add(ring);
                                        Console.WriteLine("\nFigure RING added!\n");
                                    }
                                    break;
 // в таких фигурах как квадрат, прямоугольник и треугольник, координаты точек служат не для закрепления их в пространстве, а просто для вычисления сторон
 //для закрепления в пространве(на листе бумаги) служат координаты центра фигуры.
                                case 4:
                                    {
                                        double centerX, centerY;
                                        Console.WriteLine("\nRectangle:\n" +
                                                "Enter the center coordinates");
                                        Console.Write("X: ");
                                        centerX = double.Parse(Console.ReadLine());
                                        Console.Write("\nY: ");
                                        centerY = double.Parse(Console.ReadLine());
                                        Console.Write("\nLength calculate side A");
                                        Line sideA = CreateLine();
                                        Console.Write("\nLength calculate side B");
                                        Line sideB = CreateLine();
                                        Figure rectangle = new Rectangle(centerX, centerY, sideA, sideB);
                                        figures.Add(rectangle);
                                        Console.WriteLine("\nFigure RECTANGLE added!\n");
                                    }
                                    break;
                                case 5:
                                    {
                                        double centerX, centerY;
                                        Console.WriteLine("\nSquare:\n" +
                                                "Enter the center coordinates");
                                        Console.Write("X: ");
                                        centerX = double.Parse(Console.ReadLine());
                                        Console.Write("\nY: ");
                                        centerY = double.Parse(Console.ReadLine());
                                        Console.Write("\nLength calculate side");
                                        Line sideA = CreateLine();
                                        Figure square = new Square(centerX, centerY, sideA);
                                        figures.Add(square);
                                        Console.WriteLine("\nFigure SQUARE added!\n");
                                    }
                                    break;
                                case 6:
                                    {
                                        double centerX, centerY;
                                        Console.WriteLine("\nTriangle:\n" +
                                                "Enter the center coordinates");
                                        Console.Write("X: ");
                                        centerX = double.Parse(Console.ReadLine());
                                        Console.Write("\nY: ");
                                        centerY = double.Parse(Console.ReadLine());
                                        Console.Write("\nLength calculate side A");
                                        Line sideA = CreateLine();
                                        Console.Write("\nLength calculate side B");
                                        Line sideB = CreateLine();
                                        Console.Write("\nLength calculate side C");
                                        Line sideC = CreateLine();
                                        Figure triangle = new Triangle(centerX, centerY, sideA, sideB, sideC);
                                        figures.Add(triangle);
                                        Console.WriteLine("\nFigure TRIANGLE added!\n");
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;                     
                    case 2:
                        {
                            if (figures.Count > 0)
                            {
                                foreach (var item in figures)
                                {
                                    item.Show();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nIS EMPTY:(\n");
                            }
                        }
                        break;
                    case 3:
                        {
                            if (figures.Count() > 0)
                            {
                                figures = null;
                                figures = new List<Figure>();
                                Console.WriteLine("\nALL FIGURES DELETED!\n");
                            }
                            else 
                            {
                                Console.WriteLine("\nIS EMPTY:(\n");
                            }
                        }
                        break;
                    case 4:
                        {
                            value = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid value\n");
                        value = -1;
                        break;                     
                }
            }
        }
    }
}
