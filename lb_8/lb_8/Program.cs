using System;

namespace Lb_8_1
{
    class Cat
    {
        public string Name { get; set; }
    }
    class Animals
    {
        Cat[] data;

        public Animals()
        {
            data = new Cat[6];
        }
        public Cat this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            animal[0] = new Cat() { Name = "x" };
            animal[1] = new Cat() { Name = "y" };
            Cat y = animal[1];
            Cat x = animal[0];
            Console.WriteLine(y?.Name);
            Console.WriteLine(x?.Name);
            Console.ReadKey();
        }

    }
}