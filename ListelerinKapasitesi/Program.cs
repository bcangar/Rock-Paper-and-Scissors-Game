using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListelerinKapasitesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>(5) ;
            Console.WriteLine($"Öğe adedi: {liste.Count} Kapasite: {liste.Capacity}");
            for (int i = 0; i < 40; i++)
            {
                liste.Add(1);
                Console.WriteLine($"Öğe adedi: {liste.Count} Kapasite: {liste.Capacity}");
            }



            Console.ReadKey();
        }
    }
}
