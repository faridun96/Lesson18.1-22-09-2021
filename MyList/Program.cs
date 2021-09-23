using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = new MyDictionary<int, string>();
            my.Add(1, "JavaScript");
            my.Add(2, "Go");
            my.Add(3, "C#");
            Console.WriteLine($"Общее количество элементов: {my.Count}");
            Console.WriteLine();
            Console.WriteLine($"Элементы: \n{my.ToString()}");
            Console.WriteLine($"Выбор по индексу [1]: \n{my[1]}");
            Console.WriteLine($"Выбор по индексу [2]: \n{my[2]}");
            my.Clear();
            Console.WriteLine();
            Console.WriteLine($"Удаляем все элементы.");
            Console.WriteLine($"Общее количество элементов после удаления: \n{my.Count}");
            Console.WriteLine($"Элементы после удаления: \n{my.ToString()}");
        }
    }
    class MyDictionary<Tkey, TValue>
    {
        private Tkey[] key;
        private TValue[] value;
        private int length;
        public MyDictionary()
        {
            key = new Tkey[0];
            value = new TValue[0];
            length = 0;
        }
        public void Add(Tkey tkey, TValue tvalue)
        {

            var key1 = new Tkey[length + 1];
            var value1 = new TValue[length + 1];
            for (int i = 0; i < length; i++)
            {
                key1[i] = key[i];
                value1[i] = value[i];
            }
            length++;
            key1[key1.Length - 1] = tkey;
            value1[value1.Length - 1] = tvalue;
            key = key1;
            value = value1;
        }
        public override string ToString()
        {
            string str = null;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    str += key[i] + " " + value[i] + "\n";
                }

            }
            else
                str += "Null\n";
            return str;
        }
        public void Clear()
        {
            key = new Tkey[0];
            value = new TValue[0];
            length = 0;
        }
        public int Count
        {
            get
            {
                return length;
            }
        }
        public string this[int index]
        {
            get
            {
                if (index > 0 && index < length)
                {
                    return key[index].ToString() + " " + value[index].ToString();
                }
                else
                {
                    return "в списке нет такого";
                }
            }
        }
    }
}