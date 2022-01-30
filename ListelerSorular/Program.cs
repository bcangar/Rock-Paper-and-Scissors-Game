using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListelerSorular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            //Fibonacci ilk 20 sayi

            List<int> fibonacci = new List<int>() { 0, 1 };  //{ 0,1 };   Yöntem 1

            //fibonacci.Add(0); //Yöntem 2
            //fibonacci.Add(1);

            while (fibonacci.Count < 20)

                fibonacci.Add(fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);

            Yazdir("FIBONACCI", fibonacci);

            //1-49 arası benzersiz 7 sayı (küçükten büyüğe)

            List<int> soru2 = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                int sayi = random.Next(1, 50); //1 ile 50 arasında rastgele sayı üretimi
                if (!soru2.Contains(sayi)) ; //eğer soru2 listesi, henüz yeni seçilen rastgelen sayıyı önceden içermiyorsa
                soru2.Add(sayi); //sayiyi listeye ekle
            }
            soru2.Sort(); //küçükten büyüğe sıralatır

            Yazdir("BENZERSIZ YEDILII", soru2);

            //Rakamları içeren bir liste oluşturun ve bu listeyi rastgele karıştırın.
            List<int> rakamlar = new List<int>();
            for (int i = 0; i < 10; i++)
                rakamlar.Add(i);

            Yazdir("BEFORE KARIŞIK RAKAMLAR", rakamlar);


            int talihliIndeks, gecici;
            for (int i = 0; i < rakamlar.Count - 1; i++)
            {
                talihliIndeks = random.Next(i, rakamlar.Count);
                gecici = rakamlar[i];
                rakamlar[i] = rakamlar[talihliIndeks];
                rakamlar[talihliIndeks] = gecici;
            }

            Yazdir("AFTER KARIŞIK RAKAMLAR", rakamlar);

            //1-20 aralığındaki sayılardan rastgele oluşmuş 10 elemanlı 2 ayrı liste tanımlayın.
            //Bu 2 listenin ortak elemanlarını içeren 3. listeyi oluşturun.
            //3 listeyi de yazdırın. Not: listede aynı sayılar tekrar gelmemeli

            List<int> soru4_1 = new List<int>();
            List<int> soru4_2 = new List<int>();
            List<int> soru4_3 = new List<int>();
            List<int> soru4_4 = new List<int>();

            while (soru4_1.Count < 10)
            {
                int sayi = random.Next(1, 21);
                if (!soru4_1.Contains(sayi))
                    soru4_1.Add(sayi);
            }

            while (soru4_2.Count < 10)
            {
                int sayi = random.Next(1, 21);
                if (!soru4_2.Contains(sayi))
                    soru4_2.Add(sayi);
            }



            int sayac = 0;                              //Yöntem 2 

            for (int i = 0; i < soru4_1.Count; i++)
            {
                if (soru4_2.Contains(soru4_1[i]))
                {
                    soru4_3.Add(soru4_1[i]);
                    sayac++;

                }
            }

            //foreach (var item in soru4_1) //Yöntem 1 
            //{
            //    if (soru4_2.Contains(item))
            //        soru4_3.Add(item);

            //}

            Yazdir("SORU 4 LISTE 1", soru4_1);
            Yazdir("SORU 4 LISTE 2", soru4_2);
            Yazdir("SORU 4 ORTAK", soru4_3);
            Console.WriteLine($"Listeler arasında {sayac} adet ortak sayı bulunmuştur.");





            Console.ReadKey();
        }

        static void Yazdir(string baslik, List<int> liste)
        {
            Console.WriteLine(baslik);
            Console.WriteLine(String.Join(" ", liste));
            Console.WriteLine("+" + new string('-', 60) + "+");
        }
    }
}
