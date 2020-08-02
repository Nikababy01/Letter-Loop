using System;

namespace Letter_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some letters.");
            var enteredLetters = Console.ReadLine();

            string answer = string.Empty;

            for (var i = 0; i < enteredLetters.Length; i++)
            {
                char c = enteredLetters[i];

                answer += char.ToUpper(c);

                answer += new string(char.ToLower(c), i);

                if (i < enteredLetters.Length - 1)
                {
                    answer += "-";
                }
            }
            Console.WriteLine(answer);
        }
    }
}
