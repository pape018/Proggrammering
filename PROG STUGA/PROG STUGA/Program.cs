using System;
using System.Net.Http;

namespace PROG_STUGA
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";
            //Läs in en rad från användaren
            var input = Console.ReadLine();

            //2.Kontrollera kraven på input.

            //3.Separera talet från meddelandet.
            var words = input.Split("");
            var rotation = Convert.ToInt32(words[0]);
            var message = words[1];
            
            //4.Gå igenom alla bokstäver i meddelandet

            var result = "";

            for (int i = 0; i < message.Length i++)
            {
                //4a Leta upp varenda tecken i Alfabetet
                var letter = message.ToCharArray()[1];
                var indexOfLetter = alphabet.IndexOf(letter);

                //4b.Stega framåt i alfebetet så många steg som är angiven
                var newIndex = indexOfLetter + rotation;
                var newLetter = alphabet.ToCharArray()[newIndex];

                //4c.Spara i ett resultat
                result += newLetter;
            }

            //5.Vänd på resultatet. 
            var reverseWord = ReverseString(result);

            Console.WriteLine(result);
            
        }

        private static object ReverseString(string result)
        {
            throw new NotImplementedException();
        }

        private static object ReverseString(string result, Array resultArr)
        {
            var resultAr = result.ToCharArray();
            Array.Reverse(resultArr);
            return new String((ReadOnlySpan<char>)resultArr);
        }
    }
}
