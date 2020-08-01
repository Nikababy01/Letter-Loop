using System;

namespace Letter_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are random scenarios");
            string enteredLetters = "abcd";

            string result = string.Empty;

            for (var i = 0; i < enteredLetters.Length; i++)
            {
                char c = enteredLetters[i];

                result += char.ToUpper(c);

                result += new string(char.ToLower(c), i);

                if (i < enteredLetters.Length - 1)
                {
                    result += "-";
                }
            }
            Console.WriteLine(result);
        }
    }
}
