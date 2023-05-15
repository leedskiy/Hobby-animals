using System;
using TextFile;

namespace task9
{
    class Program
    {
        public class EmptyFileError : Exception { };
        static void Main(string[] args)
        {
            TextFileReader f = new TextFileReader("input.txt");
            int count = 0;

            bool l = f.ReadInt(out count);

            if(!l)
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

                p1.addAnimal(animal, name, exLevel);
            }

            if (!l)
            {
                throw new EmptyFileError();
            }

            string temp = "";

            l = l && f.ReadString(out temp);

            if (!l)
            {
                throw new EmptyFileError();
            }

            //char[] days = new char[temp.Length];

            for(int i = 0; i < temp.Length; ++i)
            {
                
            }


            Console.WriteLine(p1.ToString());
        }
    }
}