using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kurs1= "Yazılım geliştirici kampı";
            // string kurs2= "bla bla";
            // string kurs3= "bla bla2"; e-ticaret sistemi aklına gelsin, tek tek yapamazsın.
            // array = dizi // aşağıdaki satır dizi oluşturma //

            string[] kurslar = new string[] { "Yazılım geliştirici kampı", 
             "bla bla",
             "bla bla2", "python"};

            for (int i = 0; i <kurslar.Length ; i++) // i+=2 // lenght = elelman sayısı yani üstteki kurs sayısı anlamına gelir
            {
                Console.WriteLine(kurslar [i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)     // dizileri tek tek dolaşır foreach
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
         
        
    }
}
