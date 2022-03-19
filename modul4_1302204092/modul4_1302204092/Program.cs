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
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(20);
            data.PrintAllData();

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
