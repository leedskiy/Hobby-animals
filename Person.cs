using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    class Person {
        private string name;
        private Day day;
        private List<Animal> animals;

        public Person(string n, int c) {
            name = n;
            animals = new List<Animal>(c);
        }

        public void setName(string n) {
            name = n;
        }

        public string getName(string n) {
            return name;
        }

        public void setDay(char d) {
            switch(d) {
                case 'g':
                    day = new goodDay();
                    break;
                case 'o':
                    day = new ordinaryDay();
                    break;
                case 'b':
                    day = new badDay();
                    break;
            }
        }

        public Day getDay() {
            return day;
        }

        public void addAnimal(char an, string n, int el) {
            switch (an) {
                case 'F':
                    animals.Add(new Fish(n, el));
                    break;
                case 'B':
                    animals.Add(new Bird(n, el));
                    break;
                case 'D':
                    animals.Add(new Dog(n, el));
                    break;
            }
        }

        public void takeCare() {
            day.updateExhilLevel();
        }

        public override string ToString()
        {
            string temp = "";

            foreach (Animal a in animals)
            {
                temp += a.ToString();
            }

            return temp;
        }
    }
}