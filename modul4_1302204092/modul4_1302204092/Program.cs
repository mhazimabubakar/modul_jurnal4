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

            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(20);
            data.PrintAllData();
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
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T dataBaru)
        {
            storedData.Add(dataBaru);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " 
                    + inputDates[i]);
            }
        }

    }
}
