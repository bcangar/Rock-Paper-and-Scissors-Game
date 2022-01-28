using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haftaninGunleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sonuc;




        basla:
            Console.Write("Tercihiniz:");
            string tercih = Console.ReadLine();

            switch (tercih)
            {

                case "1":
                    sonuc = "OCAK";

                    break;

                case "2":
                    sonuc = "SUBAT";

                    break;



                case "3":
                    sonuc = "MART";

                    break;

                case "4":
                    sonuc = "NISAN";

                    break;

                case "5":
                    sonuc = "MAYIS";

                    break;



                case "6":
                    sonuc = "HAZIRAN";

                    break;
                case "7":
                    sonuc = "TEMMUZ";

                    break;

                case "8":
                    sonuc = "AGUSTOS";

                    break;

                case "9":
                    sonuc = "EYLUL";

                    break;

                case "10":
                    sonuc = "EKIM";

                    break;

                case "11":
                    sonuc = "KASIM";

                    break;

                case "12":
                    sonuc = "ARALIK";

                    break;

                default:
                    Console.WriteLine("Tekrar giris yapiniz!");
                    goto basla;
                    

            }

            Console.WriteLine(sonuc);



            Console.ReadKey();





        }
    }
}
