using System;

namespace Classintro
{
    class Program
    {
         static void Main (string[] args)
        {
            string adi = "Serhat";
            int yas = 19;

            Kurs kurs1 = new Kurs();  // kendi veri tipini yazıyormuş gibi düşün
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "serhat";
            kurs2.IzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "tuba";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı" + " : " + kurs.KursAdi + " Eğitmen Adı" + " : " + kurs.Egitmen + " İzlenme Sayısı" + " : " + kurs.IzlenmeOrani);
            }

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Evo 8";
            urun1.UrunLokasyonu = "Bursa";
            urun1.UrunFiyati = 450000;

            Urun[] urunler = new Urun[] { urun1 };

            foreach (var urun in urunler)

            { Console.WriteLine(urun1.UrunAdi + urun1.UrunFiyati + urun1.UrunLokasyonu); 
            
            
            }

                

        }


        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        }

        // ödev 1: byte [0-255] sbyte [-128-127] short [-32768-32767] ushort, int, uint, long, ulong, float, double, decimal, char, string, boolean
        // ödev 2: ternary operator: ? ile gösterilir, bir bakıma if else işlevi görür.
        // ödev 3: switch komutu aslen kontrol komutudur. girilen veri kontrol edilir. 
        // ödev 4: while komutu ona atanan değere kadar bir döngüyü çalıştırır. değere ulaşıldığında döngüyü durdurur.
        // ödev 5
        
             
        
            


             class Urun
        {
            public string UrunAdi { get; set; }
            public string UrunLokasyonu { get; set; }
            public int UrunFiyati { get; set; }

        }

    }
}





       


