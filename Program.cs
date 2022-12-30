using System;

namespace MultiDimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5, 3]//regions[0, 0] = "Istanbul";
            {
                {"Istanbul","Izmit ","Balikesir "},
                {"Ankara"  ,"Konya ","Kirkale "},
                {"Antalya" ,"Adana ","Mersin "},
                {"Rize"    ,"Trabzon ","Samsun "},
                {"Izmir"   ,"Mugla ","Manisa "},

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j= 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();
        }
    }
}
