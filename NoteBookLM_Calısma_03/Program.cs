using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookLM_Calısma_03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Araba car1 = new Araba();

            car1.Model = 2023;
            car1.Marka = "BMW";
            car1.Hiz = 2000;

            Araba car2 = new Araba(); // sdsfsdfsdfsdfs
            car2.Model = 1990;
            car2.Marka = "TOFAŞ";
            car2.Hiz =110;

            car1.ArabaIsim();
            car2.ArabaIsim();
        }
    }

    class   Araba
    {

        public int Model;
        public string Marka;
        public int Hiz;



        public void ArabaIsim()
        {

            Console.WriteLine($"{Model} Model {Marka} arabamızın hız: {Hiz} ");

        }



    }


}
