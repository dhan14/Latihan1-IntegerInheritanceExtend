using System;

namespace TugasInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buat objek baru
            Sedan vios = new Sedan();
            Boeing airAsia737 = new Boeing();

            //lakukan prosedur
            Console.WriteLine("Saya Mobil Vios");
            vios.kadarOktan();
            Console.WriteLine("Bahan bakar saya adalah " + vios.bahanBakar());
            vios.jenisTransport();
            vios.berjalan();
            Console.WriteLine("Saya Pesawat Air Asia Boeing 737");
            airAsia737.kadarOktan();
            Console.WriteLine("Bahan bakar saya adalah " + airAsia737.bahanBakar());
            airAsia737.jenisTransport();
            airAsia737.berjalan();
        }
    }
}