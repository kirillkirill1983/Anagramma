using System;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var anagrama = new Anagrama();
            Console.WriteLine("Please enter text or word");
            var mylineRevers = Console.ReadLine();
            try
            {
                var resultRevers = anagrama.Reverse(mylineRevers);
                Console.WriteLine(resultRevers);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
