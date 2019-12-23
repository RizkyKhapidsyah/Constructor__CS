using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor__CS
{
    class Anggota
    {
        public string Nama = "Rizky Khapidsyah";
        public int Umur = 28;

        public Anggota()
        {
            Console.WriteLine("Halloo, Nama saya Adalah: {0} ", Nama);
        }

        public Anggota(string NamaParam)
        {
            Nama = NamaParam;
            Console.WriteLine("Nama Panggilan Saya Adalah: {0}", Nama);
        }

        public Anggota(int UmurParam)
        {
            Umur = UmurParam;
            Console.WriteLine("Usia Saya Adalah: {0}", Umur + " Tahun");
        }
    }
}
