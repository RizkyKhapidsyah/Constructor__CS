using System;

namespace Constructor__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] SInput = new String[2];
            int umurMain;

            Anggota[] K = new Anggota[3];

            //Tampilan Awal
            K[0] = new Anggota();
            K[1] = new Anggota("Rizky");
            K[2] = new Anggota(102);


            Console.Write("\n\nNama Panggilan Anda : "); SInput[0] = Console.ReadLine();
            Console.Write("Berapa Umur Anda?   : "); umurMain = Convert.ToInt32(SInput[1] = Console.ReadLine());
            Console.WriteLine("\n");

            K[1] = new Anggota(SInput[0]);
            K[2] = new Anggota(umurMain);

            Console.ReadLine();
        }
    }
}
