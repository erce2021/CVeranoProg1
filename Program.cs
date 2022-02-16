using System;
using System.Collections;

namespace ConsoleApp1
{
    class ArrayListDemo
    {

        static void Main(string[] args)
        {
            ArrayList numArrList = new ArrayList();
            numArrList.Add(10);
            numArrList.Add(20);
            numArrList.Add(30);
            numArrList.Add(40);
            numArrList.Add(50);

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int temp in numArrList)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            ArrayList MixedArrlst = new ArrayList();

            MixedArrlst.Add(10.12);
            MixedArrlst.Add(20020014124111);
            MixedArrlst.Add(30.14245474574);
            MixedArrlst.Add("Some String");
            MixedArrlst.Add(50);

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var temp in MixedArrlst)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            //Arreglo junto

            ArrayList Arrlst = new ArrayList();

            Arrlst.Add(11);
            Arrlst.Add(22);
            Arrlst.Add(33);

            ArrayList Arrlst_Range2 = new ArrayList();

            Arrlst_Range2.Add(12);
            Arrlst_Range2.Add(24);
            Arrlst_Range2.Add(36);
            Arrlst.AddRange(Arrlst_Range2);

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var temp in Arrlst)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            //Insert
            ArrayList Arrlst_Insert = new ArrayList();

            Arrlst_Insert.Add(5);
            Arrlst_Insert.Add(11);
            Arrlst_Insert.Add(17);
            Arrlst_Insert.Add(33);
            Arrlst_Insert.Add(44);
            Arrlst_Insert.Add(55);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var temp in Arrlst_Insert)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }

            Arrlst_Insert.Insert(4, "A String at specified pos");

            Console.WriteLine("\n**************After Insert Method**************\n");
            foreach (var temp in Arrlst_Insert)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            ArrayList Arrlst_insertRange = new ArrayList();

            Arrlst_insertRange.Add(1);
            Arrlst_insertRange.Add(2);
            Arrlst_insertRange.Add(3);

            ArrayList Arrlst_insertRange2 = new ArrayList();

            Arrlst_insertRange2.Add("a");
            Arrlst_insertRange2.Add("b");
            Arrlst_insertRange2.Add("c");

            Arrlst_insertRange.InsertRange(0, Arrlst_insertRange2);

            foreach (var temp in Arrlst_insertRange)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            ArrayList Arrlst_clear = new ArrayList();

            Arrlst_clear.Add(1);
            Arrlst_clear.Add(2);
            Arrlst_clear.Add(3);
            Arrlst_clear.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (var temp in Arrlst_clear)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }
            Console.ReadLine();

            ArrayList Arrlst_Remove = new ArrayList();

            Arrlst_Remove.Add(1);
            Arrlst_Remove.Add(2);
            Arrlst_Remove.Add(3);
            Arrlst_Remove.Add(3);
            Arrlst_Remove.Add(1);
            Arrlst_Remove.Add(2);

            Arrlst_Remove.Remove(2);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var temp in Arrlst_Remove)
            {
                Console.WriteLine("ArrayList item = " + temp);
            }

        }
    }
}
