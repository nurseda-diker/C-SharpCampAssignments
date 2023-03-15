using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> student = new MyDictionary<int, string>();
            student.Add(1, "Ahmet");
            student.Add(2, "Ayşe");
           
            
        }
    }

    class MyDictionary<T1,T2>
    {
        T1[] items;
        T2[] items2;
        T1[] _tempArray;
        T2[] _tempArray2;

        public MyDictionary()
        {
            items = new T1[0];
            items2 = new T2[0];
        }

        public void Add(T1 item,T2 item2)
        {
            _tempArray = items;
            _tempArray2 = items2;
            items = new T1[items.Length + 1];
            items2 = new T2[items2.Length + 1];
            for(int i = 0; i < _tempArray.Length; i++)
            {
                items[i]=_tempArray[i];
                items2[i] = _tempArray2[i];
            }

            items[items.Length-1] = item;
            items2[items2.Length-1] = item2;

        }
    }
}
