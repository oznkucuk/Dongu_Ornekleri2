using System;

namespace carpim_tablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            // İçiçe for döngüsü kullanılarak çarpım tablosu oluşturma
            CarpimTablosu();


        }

        private static void CarpimTablosu()
        {
                       Console.WriteLine("*-*-*- ÇARPIM TABLOSU -*-*-*");

            for (int i = 1; i <= 10; i++)
            {   
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                    
                }
            Console.WriteLine("*****************");
            }
        }
    }
}
