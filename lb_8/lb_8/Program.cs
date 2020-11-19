using System;

namespace Lb_8_1
{
    class MyClass
    {
        private int[] myArray = new int[] { 1, 2, 3 };
        private string x = "x";
        public int this[int index]
        {
            set { myArray[index] = value; }
            get { return myArray[index]; }
        }
        public string this[string i]
        {
            get { return x; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance[2] = 1;
            for (int i = 0; i < 3; i++) ;
            {
                Console.WriteLine(instance["index"]);
            }
            Console.WriteLine(instance["index2"]);
            Console.ReadKey();
        }
    }
}
