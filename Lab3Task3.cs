namespace Lab3Task3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("TASK 3");
            Console.WriteLine("Choose a shape: 1 - Square, 2 - Circle, 3 - Rectangle, 4 - Triangle");
            int shapeNumber = int.Parse(Console.ReadLine());
            float pi = 3.14f;

            switch (shapeNumber) {
                case 1: {
                        Console.Write("Enter the side: ");
                        float side = float.Parse(Console.ReadLine());
                        float squareArea = side * side;
                        Console.WriteLine($"Area = {squareArea:F2}");
                        break;
                    }
                case 2: {
                        Console.Write("Enter the radius: ");
                        float circleRadius = float.Parse(Console.ReadLine());
                        float circleArea = pi * circleRadius * circleRadius;
                        Console.WriteLine($"Area = {circleArea:F2}");
                        break;
                    }
                case 3: {
                        Console.Write("Enter the first side: ");
                        float rectangleSideA = float.Parse(Console.ReadLine());
                        Console.Write("Enter the second side: ");
                        float rectangleSideB = float.Parse(Console.ReadLine());
                        float rectangleArea = rectangleSideA * rectangleSideB;
                        Console.WriteLine($"Area = {rectangleArea:F2}");
                        break;
                    }
                case 4: {
                        Console.Write("Enter the base: ");
                        float triangleBase = float.Parse(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        float triangleHeight = float.Parse(Console.ReadLine());
                        float triangleArea = triangleBase * triangleHeight / 2;
                        Console.WriteLine($"Area = {triangleArea:F2}");
                        break;
                    }
                default: {
                        Console.WriteLine("Wrong choice. Enter a number from 1 to 4.");
                        break;
                    }
            }
            Console.WriteLine("-------------------");
        }
    }
}
