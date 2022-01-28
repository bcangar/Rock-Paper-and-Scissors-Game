using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, computerScore = 0; //kullanici ve bilgisayar skorlari tanimlanarak,baslangic degerleri atanmistir.
            do
            {
                Random rand = new Random();

                string[] degisken = { "r", "p", "s" };

            basla:

                int pcTercih = rand.Next(0, 3); 
                string pcTahmin = degisken[pcTercih];
                Console.WriteLine("Rock icin r,paper icin p,scissors için ise s ye basınız.exit için e yada/exit basınız.");
                string tercih = Console.ReadLine();

                switch (tercih)
                {
                    case "r":
                    case "R":
                    case "Rock":

                        if (pcTahmin == "p")
                        {
                            computerScore++;
                            Console.WriteLine("Bilgisayar kazandi.");
                        }

                        else if (pcTahmin == "s")
                        {
                            playerScore++;
                            Console.WriteLine("Oyuncu kazandi.");
                        }
                        else Console.WriteLine("Berabere");

                        break;

                    case "p":
                    case "P":
                    case "Paper":

                        if (pcTahmin == "s")
                        {
                            computerScore++;
                            Console.WriteLine("Bilgisayar kazandi.");
                        }

                        else if (pcTahmin == "r")
                        {
                            playerScore++;
                            Console.WriteLine("Oyuncu kazandi.");
                        }
                        else Console.WriteLine("Berabere");

                        break;

                    case "s":
                    case "S":
                    case "Scissors":

                        if (pcTahmin == "r")
                        {
                            computerScore++;
                            Console.WriteLine("Bilgisayar kazandi.");
                        }

                        else if (pcTahmin == "p")
                        {
                            playerScore++;
                            Console.WriteLine("Oyuncu kazandi.");
                        }
                        else Console.WriteLine("Berabere");
                        break;

                    case "e":
                    case "E":
                    case "Exit":

                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Yanlis tercih!Tekrar deneyiniz.");
                        goto basla;


                }

                Console.WriteLine("Oyuncu skoru:" + playerScore);
                Console.WriteLine("Bilgisayar skoru:" + computerScore);
                Console.WriteLine("Devam etmek icin ENTER a basınız.");
                Console.ReadLine();
                Console.Clear();
            } while (true);



        }
    }
}
