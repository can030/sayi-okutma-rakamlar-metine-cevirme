using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıokutma_rakamları_metine_çevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] birler = { "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "on", "yirmi", "otuz", "kırk", "elli", "atmış", "yetmiş", "seksen", "doksan" };
            bool uygunmu = false;
            int sayi = 0;
            bool tekraret;
            do 
            {
            while (!uygunmu)
            {
                Console.Write("lütfen metine çevirmek istediniz sayıyı giriniz : ");
                uygunmu = int.TryParse(Console.ReadLine(), out sayi);
                if (sayi < 0 || sayi > 9999)
                {
                    uygunmu = false;
                }
            }
            if (sayi >999)
            {
                int binlerbasamagi = (sayi - (sayi % 1000)) / 1000;
                if (binlerbasamagi == 1 )
                {
                    Console.WriteLine("bin");
                }
                else
                {
                    Console.WriteLine(birler[binlerbasamagi]+"bin");
                }
            }
             if(sayi > 99)
            {
                int yüzlerbasamagı = (sayi - (sayi %100)/100)%10;
                if (sayi !=0 )
                {
                    Console.WriteLine("yüz");
                }
                else
                {
                    Console.WriteLine(onlar[yüzlerbasamagı]+"yüz");
                }
            }
            if (sayi > 9)
            {
                int onlarBasamagi = ((sayi % 100) - (sayi % 10)) / 10;
                Console.Write(onlar[onlarBasamagi] + " ");
            }

            if (sayi > 0)
            {

                int birlerBasamagi = sayi % 10;
                if (!(birlerBasamagi == 0))
                {
                    Console.Write(birler[birlerBasamagi]);
                }
            }
            else
            {
                Console.WriteLine("Sıfır");
            }
            Console.WriteLine();
            Console.WriteLine("tekrar sormak istermisiniz : ");
            string tekraretInput = Console.ReadLine()?.Trim().ToUpper();
            tekraret = (tekraretInput == "E");


        } while (tekraret);


            Console.ReadLine();
        }
    }
}
