using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    class Person {
        string name;
        List<Animal> animals;

        public Person(string n) {
            name = n;
            animals = new List<Animal>();
        }

        public void addAnimal(string an, string n, int el) {
            switch (an) {
                case "fish":
                    animals.Add(new Fish(n, el));
                    break;
                case "bird":
                    animals.Add(new Bird(n, el));
                    break;
                case "dog":
                    animals.Add(new Dog(n, el));
                    break;
            }
        }

        public void takeCare(Day day) {
            foreach(Animal a in animals) {
                a.updateExhilLevel(day);
            }
        }

        public override string ToString()
        {
            //string temp = "";

            //foreach (Animal a in animals)
            //{
            //    temp += "(" + a.GetType() + ", " + a.getName() + ", " + a.getExhilLevel() + ")" + " ";
            //}

            //return temp;
            string temp = "";

            foreach (Animal a in animals)
            {
                temp += a.ToString();
            }

            return temp;
        }
    }
}