using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace noteBookLM_02
{


    class ogrenci
    {
     
        public string isim;
        public string soyad;
        public int okulNo;

        public void ogrenciID()
        {
           
            Console.WriteLine($" {isim} {soyad} öğrencinin numarası : {okulNo}   ");
              
        }

    
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.Write("Lütfen bir sayı yazınız: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Girdiğiniz sayının karesi: ");
            //Console.WriteLine(KareAl(sayi));
            //Console.Write("Girdiğiniz sayının küpü: ");
            //Console.WriteLine(KupAl(sayi));
            #endregion


            int sart = 1;
            int sayac = 0;
            while (sart==1)
            {

            ogrenci number1 = new ogrenci();
            Console.Write("Öğrencinin ismini giriniz: ");
            number1.isim = Console.ReadLine();
            Console.Write("Öğrencinin soyadını giriniz: ");
            number1.soyad = Console.ReadLine();
            Console.Write("Öğrencinin okul numarasını giriniz: ");
            number1.okulNo = int.Parse(Console.ReadLine());
            number1.ogrenciID();
                Console.WriteLine();
                Console.Write("Yeni öğrenci kaydetmek için 1 'e / Sistemden çıkmak için 0 ' a basınız: ");
              
                sart = int.Parse(Console.ReadLine());
                sayac++;
                
            }

            Console.WriteLine(sayac +" tane öğrenci kayıt yapmıştır. ");






        }
        #region    
        //static int KareAl(int number)
        //{

        //    return number * number;
        //}
        //static int KupAl(int number)
        //{
        //    return number*number*number;
        //}

        //static string EkranaYaz(string mesaj , int tekrarSayisi)
        //{
        //    for (int i= 0; i<tekrarSayisi;i++)
        //    {
        //        Console.WriteLine((i+1)+". "+mesaj);
        //    }

        //    return mesaj;

        //}
        #endregion

        #region
        //static void BolmeIslemi()
        //{
        //    while (true) { 
        //    try
        //    {                            
        //                Console.Write("Bölme işlemi yapmak için lütfen birinci sayıyı giriniz: ");
        //                int number1 = int.Parse(Console.ReadLine());
        //                Console.Write(" İkinci sayıyı giriniz: ");
        //                int number2 = int.Parse(Console.ReadLine());
        //                double sonuc = number1 / number2;
        //                Console.WriteLine("İşlemin Sonucu: " + sonuc);
        //            return;
           
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("HATA : İşlemi yapamak için lütfen sayı girmeniz gerekmektedir.");
               
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("HATA : Sıfır hiçbir sayıya bölünmez. ");
              
        //    }

        //    }
        //}
        #endregion

    }
}
