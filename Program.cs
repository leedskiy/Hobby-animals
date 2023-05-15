using System;
using TextFile;

namespace task9
{
    class Program
    {
        public class EmptyFileError : Exception { };
        static void Main(string[] args)
        {
            //p1.addAnimal("fish","Nemo", 50);
            //p1.addAnimal("fish","Nemo", 50);
            //p1.addAnimal("fish","Nemo", 50);

            TextFileReader f = new TextFileReader("input.txt");
            int count = 0;
            char animal = '0';
            string name = "";
            int exLevel = 0;

            bool l = f.ReadInt(out count);

            Person p1 = new Person("Cathy", count);

            for (int i = 0; i < count && l; ++i)
            {
                l = l && f.ReadChar(out animal);
                l = l && f.ReadString(out name);
                l = l && f.ReadInt(out exLevel);

                switch(animal)
                {
                    case 'F':
                        p1.addAnimal("fish", name, exLevel);
                        break;
                    case 'B':
                        p1.addAnimal("bird", name, exLevel);
                        break;
                    case 'D':
                        p1.addAnimal("dog", name, exLevel);
                        break;
                }
            }

            Console.WriteLine(p1.ToString());
        }
    }
}