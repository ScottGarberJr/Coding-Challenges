using System;

namespace CompareWordsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's compare the word lengths of words you enter! Yaaay\n");

            string[] words = GetWords();

            ShowWords(words);

            CompareWordsInArray(words);

            Console.WriteLine("\nPress enter to quit...");
            Console.ReadLine();

        }

        static string[] GetWords()
        {
            Console.WriteLine("Enter in your words separated by a space: ");

            char[] seperators = { ' ', '\t' };
            string inputs = Convert.ToString(Console.ReadLine());
            string[] words = inputs.Split(seperators);
            return words;
            
        }

        static void ShowWords(string[] words)
        {
            int wordCount = 0;
            Console.Write("\nYour words: ");
            foreach (var word in words)
            {
                if (wordCount >= words.Length - 1)
                {
                    Console.Write($"and {word}.");
                }
                else
                {
                    Console.Write($"{word}, ");
                }
                wordCount++;
            }

        }

        static void CompareWordsInArray(string[] words)
        {
            int ind_longest=0, ind_shortest=0, size_longest=0, size_shortest=0;

            for (int index = 0; index < words.Length; index++)
            {
                if(words[index].Length > size_longest)
                {
                    ind_longest = index;
                    size_longest = words[index].Length;
                }
                if (words[index].Length < size_shortest)
                {
                    ind_shortest = index;
                    size_shortest = words[index].Length;
                }
            }
            Console.WriteLine($"\n\nThe first word listed with the most characters was {words[ind_longest]}.");
            Console.WriteLine($"The first word listed with the least characters was {words[ind_shortest]}.");


        }
    }
}

