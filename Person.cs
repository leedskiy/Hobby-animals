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

        public void addAnimal(Animal a, string n, int el) {
            animals.add(new Animal(n, el));
        }

        public void takeCare(Day day) {
            foreach(Animal a in animals) {
                a.updateExhilLevel(day);
            }
        }
    }
}