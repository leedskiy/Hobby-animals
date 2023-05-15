using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Cathy");
            p1.addAnimal("fish","Nemo", 50);
            p1.addAnimal("dog","fff", 18);

            Console.WriteLine(p1.ToString());
        }
    }
}