using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListelereGiris
{
    internal class Program
    {
        static List<string> adlar = new List<string>() { "Mustafa", "Ulaşcan", "John", "Furkan", "Gül", "John" };
        static void Main(string[] args)

        {
            //Console.OutputEncoding = Encoding.UTF8; //Noktalı harflerin görünmesi için 



            // List<string> adlar = new List<string>() { "Mustafa","Ulaşcan", "John", "Furkan","Gül", "John" };

            //Console.WriteLine("Listenin şu anki eleman sayısı: "+adlar.Count);

            //foreach(string ad in adlar)
            //    Console.WriteLine("*"+ ad );

            //    Console.WriteLine("\r\n--------------------\r\n");

            //buldugun ilk John u sil

            Listele("Başlangıçtaki");

            adlar.Remove("John");
            Listele("İlk John u silme sonrası");

            adlar[1] = adlar[1].Substring(0, 4);
            Listele("Ulaşcan Ulaş olduktan sonra");

            adlar.Add("İrem");
            Listele("İrem eklendikten sonra");

            adlar.Sort();
            Listele("Alfabetik sıralama sonrası");

            adlar.Insert(0, "Mustafa");
            Listele("Mustafa başa eklendikten sonra");


            // Gül ün indeks nosunu bilmediginizi varsayın
            //Gül ün öncesine Oğuz nasıl eklenir?

            int gi = adlar.IndexOf("Gül");
            adlar.Insert(gi, "Oğuz");


            Listele("Oğuz Gül ün önesine eklendikten sonra");


            for (int j = 0; j < adlar.Count; j++)     //Dizinin elemanlarını baştan sona doğru, metin uzunluklarıyla birlikte yazdırınız.
            {
                Console.Write(adlar[j] + " " + adlar[j].Length + " ");
            }
            Console.WriteLine(" ");

            for (int j = 0; j < adlar.Count; j++)   //Dizinin elemanlarından sadece "m" veya "M" içerenleri yazdırınız.
            {
                if (adlar[j].Contains("m") || adlar[j].Contains("M"))
                    Console.Write(adlar[j] + " ");
            }

            Console.WriteLine(" ");

            for (int j = adlar.Count - 1; j >= 0; j--)   //Dizinin elemanlarını sondan başa doğru yan yana yazdırınız. //Yöntem 1 
            {
                Console.Write(adlar[j] + " ");
            }
            //adlar.Reverse();                           //Yöntem 2 (Dizinin orjinal halini bozuyor.)
            //Console.Write(String.Join(", ",adlar));

            Console.WriteLine(" ");

            //Yöntem 3(Yöntem 2 nin orjinalini bozmamış hali)

            var tersten = adlar.ToArray(); //= adlar.ToList(); diye de yazabilirdik
            Array.Reverse(tersten);
            Console.WriteLine(string.Join(" ", tersten));

            Console.WriteLine(" ");

            Listele("Birtakım işlemler sonrası");

            //Üçüncü indeksteki eleman ile beşinci indeksteki elemanın yerlerini değiştirip, yazdırınız.

            var temp = adlar[3];
            adlar[3] = adlar[5];
            adlar[5] = temp;
            Listele("Üçüncü ile beşinci yer değiştirdikten sonrası");


            //Listedeki tüm elemanları büyük harfli hale getiriniz.

            for (int i = 0; i < adlar.Count; i++)
            {
                adlar[i] = adlar[i].ToUpper();
            }

            Listele("Karakterleri büyüttükten sonra");


            //Listedeki elemanların indekslerini birer arttır, sonuncu elemanı da başa getir.

            adlar.Insert(0, adlar[adlar.Count - 1]);
            adlar.RemoveAt(adlar.Count - 1);

            Listele("Tümünü kaydırdıktan sonra");



            Console.ReadKey();
        }



        static void Listele(string aciklama = "")
        {
            Console.WriteLine(aciklama + " eleman sayısı: " + adlar.Count);

            for (int i = 0; i < adlar.Count; i++)
                Console.WriteLine($"[{i}] {adlar[i]}");

            Console.WriteLine("\r\n--------------------\r\n");



            //foreach (string ad in adlar)
            //    Console.WriteLine("*" + ad);

            //Console.WriteLine("\r\n--------------------\r\n");

        }
    }
}
