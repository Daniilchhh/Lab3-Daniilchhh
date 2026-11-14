namespace Lab3Task2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("TASK 2");
            Console.Write("Enter text: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter X: ");
            int wordsToRemove = int.Parse(Console.ReadLine());

            string[] words = sentence.Split(' ');

            string textWithoutWords = "";
            for (int i = wordsToRemove; i < words.Length; i++) {
                if (i > wordsToRemove) {
                    textWithoutWords += " ";
                }
                textWithoutWords += words[i];
            }

            Console.WriteLine("Result: " + textWithoutWords);
            Console.WriteLine("-------------------");
        }
    }
}
