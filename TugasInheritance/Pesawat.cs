using System;

namespace TugasInheritance
{
    public class Pesawat : Transportasi
    {
        public Pesawat()
        {

        }
        public void jenisTransport()
        {
            Console.WriteLine("Di Udara");
        }
        public string bahanBakar()
        {
            return "avgas";
        }
    }
}