using System;
using TextFile;

namespace task9
{
    class Program
    {
        public class EmptyFileError : Exception { };
        public class IncorrectExhilLevel : Exception { };

        static void Main(string[] args)
        {
            start("input.txt");
        }

        static void start(string fileName)
        {
            TextFileReader f = new TextFileReader(fileName);
            int count = 0;

            bool l = f.ReadInt(out count);

            if (!l)
            {
                throw new EmptyFileError();
            }

            Person p1 = new Person("Cathy", count);

            char animal = '0';
            string name = "";
            int exLevel = 0;

            for (int i = 0; i < count && l; ++i)
            {
                l = l && f.ReadChar(out animal);
                l = l && f.ReadString(out name);
                l = l && f.ReadInt(out exLevel);

                if (exLevel < 0 || exLevel > 100)
                {
                    throw new IncorrectExhilLevel();
                }

                p1.addAnimal(animal, name, exLevel);
            }

            string temp = "";
            l = l && f.ReadString(out temp);

            for (int i = 0; i < temp.Length; ++i)
            {
                p1.setDay(temp[i]);
                p1.takeCare();
            }

            Console.WriteLine("List of all " + p1.getName() + "'s animals:");
            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine("Animal(s) with the lowest level of exhilaration which is/are still alive:");
            string lwsAns = "";
            foreach (Animal a in p1.getLowestELAnimals())
            {
                lwsAns += a + " ";
            }
            Console.WriteLine(lwsAns);
        }
    }
}