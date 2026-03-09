using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace noteBookLM_02
{


    class ogrenci
    {

        public static int kayitliOgrenciSayisi = 0;

        public string isim;
        public string soyad;
        public long okulNo;
public ogrenci( string _isim,string _soyad , long _okulNo  )
        {
            isim = _isim;
            soyad = _soyad;
            okulNo = _okulNo;
            kayitliOgrenciSayisi++;

        }

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
            
            while (sart==1)
            {              
                              
            Console.Write("Öğrencinin ismini giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Öğrencinin soyadını giriniz: ");
            string soyad = Console.ReadLine();
            Console.Write("Öğrencinin okul numarasını giriniz: ");
            long okulNo = long.Parse(Console.ReadLine());
            
                ogrenci yeniOgrenci = new ogrenci(isim , soyad, okulNo);
                Console.WriteLine();
                Console.Write("Yeni öğrenci kaydetmek için 1 'e / Sistemden çıkmak için 0 ' a basınız: ");
              
                sart = int.Parse(Console.ReadLine());
                              
            }
            
            Console.WriteLine(ogrenci.kayitliOgrenciSayisi+ " tane öğrenci kayıt yapmıştır. ");
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
