using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Tugas1
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //inheritance
            Console.WriteLine("Terbang lah pesawatku di udara .. !!!");
            Pesawat pesawat = new Pesawat();

            pesawat.Melaju();
            Console.WriteLine("Warna Pesawat :{0} ", pesawat.Warna);
            Console.WriteLine("Kecepatan Pesawat :{0} ", pesawat.Kecepatan);
            Console.WriteLine("Jumlah roda Pesawat :{0} ", pesawat.JumlahRoda);

            //Console.ReadKey();
        }
    }

    class Program : NewBaseType
    {
    }
}