using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            string nizZnakova, sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11;

            Console.WriteLine("Unesite niz znakova koji nije manji od 11:");
            nizZnakova = Console.ReadLine();

            sVelika = nizZnakova.ToUpper();
            Console.WriteLine(sVelika);

            sMala = nizZnakova.ToLower();
            Console.WriteLine(sMala);

            
            Console.WriteLine(nizZnakova.Substring(0, 3));

            Console.WriteLine(nizZnakova.Substring(nizZnakova.Length-5));

            Console.WriteLine(nizZnakova.Substring(8, 11));

        }
    }
}
