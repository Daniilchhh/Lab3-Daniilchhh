namespace Lab3Task4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("TASK 4");
            Console.Write("Enter text: ");
            string inputText = Console.ReadLine();

            string replacedText = "";
            for (int i = 0; i < inputText.Length; i++) {
                int position = i + 1;

                if (position % 15 == 0) {
                    replacedText += '?';
                } else if (position % 3 == 0) {
                    replacedText += 'X';
                } else if (position % 5 == 0) {
                    replacedText += '9';
                } else {
                    replacedText += inputText[i];
                }
            }

            Console.WriteLine("Result: " + replacedText);
            Console.WriteLine("-------------------");
        }
    }
}
