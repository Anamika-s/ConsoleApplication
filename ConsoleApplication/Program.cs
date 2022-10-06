
using System;
using Common.Functions;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            NumericFunctions numericFunctions = new NumericFunctions();
            int   result = numericFunctions.AddNumbers(10, 20);
            Console.WriteLine($"Result is {result}");
            result = NumericFunctions.SubtractNumbers(20, 10);
            Console.WriteLine($"Result is {result}");
            string table = numericFunctions.PrintTable(10);
            Console.WriteLine(table);
            //StringFunctions stringFunctions = new StringFunctions();
            int countOfWords = StringFunctions.CountNumOfWordsInSentence("This is a book of C#");
            Console.WriteLine($"No if words in sentnecs are {countOfWords}"); ;
        }
    }
}
