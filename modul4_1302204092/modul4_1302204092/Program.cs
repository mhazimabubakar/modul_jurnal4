using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hasil Penjumlahan 13 + 02 + 20 = ");
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(13, 02, 20));
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic temp1 = input1;
            dynamic temp2 = input2;
            dynamic temp3 = input3;
            return temp1 + temp2 + temp3;
        }
    }
}
