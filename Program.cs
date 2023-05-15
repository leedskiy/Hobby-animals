using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Cathy");
            p1.addAnimal(Fish.Instance(), "Nemo", 50);
        }
    }
}