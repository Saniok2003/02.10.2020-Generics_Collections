using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Program
{
    class Dict
    {
        public Dict(int wa)
        {
            Dictionary<string, string> a = new Dictionary<string, string>(wa);
        }
        public void AddE(Dictionary<string, string> dict, string a, string b)
        {
            dict.Add(a, b);
        }
        public void Show(Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /// 1
            ArrayList list = new ArrayList();
            List<bool> boolList = new List<bool>();
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            list.Add(true);
            list.Add(false);
            list.Add(2.33);
            list.Add(3.56);
            list.Add(5);
            list.Add(999);
            foreach (object o in list)
            {
                if (o is bool)
                {
                    boolList.Add((bool)o);
                }
                else if (o is int)
                {
                    intList.Add((int)o);
                }
                else if (o is double)
                {
                    doubleList.Add((double)o);
                }
            }
            WriteLine("Bool list");
            for (int i = 0; i < boolList.Count; i++)
            {
                WriteLine($"{i + 1}: {boolList[i]}");
            }
            WriteLine();
            WriteLine("Int list");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {intList[i]}");
            }
            WriteLine();
            WriteLine("Double list");
            for (int i = 0; i < doubleList.Count; i++)
            {
                WriteLine($"{i + 1}: {doubleList[i]}");
            }
            WriteLine();

            /// 2

            List<string> stringListd = new List<string>();
            stringListd.Add("Hello");
            stringListd.Add("you");
            stringListd.Add("ftor");
            string word = "";
            bool a = true;
            for (int i = 0; i < stringListd.Count; i++)
            {
                for (int j = 0; j < stringListd.Count; j++)
                {
                    if (stringListd[i].Length > stringListd[j].Length & a)
                    {
                        word = stringListd[i];
                        a = false;
                    }
                    if (word.Length < stringListd[j].Length & !a)
                    {
                        word = stringListd[j];
                    }
                }
            }
            WriteLine(word);

            /// 3

            Dictionary<string, string> dictit = new Dictionary<string, string>(6);
            Dict dicti = new Dict(10);
            dicti.AddE(dictit,"Pein","+390213124124");
            dicti.AddE(dictit,"Itachi","+390213124124");
            dicti.AddE(dictit,"Toby","+390245745747");
            dicti.Show(dictit);
        }
    }
}