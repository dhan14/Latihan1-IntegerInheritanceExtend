using System;

namespace TugasInheritance
{
    public class Mobil : Transportasi
    {
        public Mobil()
        {

        }
        public void jenisTransport()
        {
            Console.WriteLine("Di Darat");
        }
        public string bahanBakar()
        {
            return "bensin";
        }
    }
}