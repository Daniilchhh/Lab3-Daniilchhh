namespace Lab3Task1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("TASK 1");
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
 
            bool isNegative = number < 0;
            if (isNegative) {
                number = -number;
            }
 
            long reversedNumber = 0;
            while (number > 0) {
                long lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = number / 10;
            }
 
            if (isNegative) {
                reversedNumber = -reversedNumber;
            }
 
            Console.WriteLine("Result: " + reversedNumber);
            Console.WriteLine("-------------------");
        }
    }
}
