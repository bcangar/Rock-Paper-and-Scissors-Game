using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanicidanAlinanSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {//Kullanıcıdan alınan sayının kullanıcı tarafından seçtiği işleme göre 
         //1 karesi,2 küpü,3 karekök hesaplayan programı yazınız.


            do
            {
                double sonuc;


                Console.Write("Sayı:");

                int sayi = Convert.ToInt32(Console.ReadLine());


            basla:
                Console.Write("Tercihiniz:");
                string tercih = Console.ReadLine();

                switch (tercih)
                {

                    case "1":
                        sonuc = Math.Pow(sayi, 2);

                        break;

                    case "2":
                        sonuc = Math.Pow(sayi, 3);

                        break;



                    case "3":
                        sonuc = Math.Sqrt(sayi);

                        break;

                    default:
                        Console.WriteLine("Tekrar giris yapiniz!");
                        goto basla;


                }

                Console.WriteLine(sonuc);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);





        }
    }
}
