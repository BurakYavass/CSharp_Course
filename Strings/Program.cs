using System;

namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Burak Yavas";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Meltem Ersoy";

            // Cumle son karakterine bakar
            // result2 sentencen clone oldugu icin ona baktik
            // bool result3 = result2.ToString().EndsWith("s");
            // // sentencen degistikten sonraki haline bakiyoruz
            // bool result4 = sentence.EndsWith("y");
            // Console.WriteLine(result3);
            // Console.WriteLine(result4);
            bool result5 = sentence.StartsWith("My name");

            var result6 = sentence.IndexOf("name");
            var result7 = sentence.IndexOf(" ");
            var result8 = sentence.LastIndexOf(" ");
            var result9 = sentence.Insert(0,"Hello, ");
            var result10 = sentence.Substring(3,4);
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ","_");
            var result14 = sentence.Remove(2,2);
            
            
            Console.WriteLine(result14);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var character in city)
            {
                Console.WriteLine(character);
            }

            string city2 = "Istanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}