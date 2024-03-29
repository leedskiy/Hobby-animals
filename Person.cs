using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    public class Person {
        public class AllAnimalsDied : Exception { };

        private string name;
        private IDay day;
        private List<Animal> animals;

        public Person(string n, int c) {
            name = n;
            animals = new List<Animal>(c);
        }

        public string getName() {
            return name;
        }

        private bool everyELevelAtl5() {
            bool greater = true;
            
            for(int i = 0; i < animals.Count && greater; ++i) {
                if(animals[i].getExhilLevel() < 5) {
                    greater = false;
                }
            }

            return greater;
        }

        public void setDay(char d) {
            switch(d) {
                case 'g':
                    day = GoodDay.Instance();
                    break;
                case 'o':
                    if(everyELevelAtl5()) {
                        day = GoodDay.Instance();
                        break;
                    }

                    day = OrdinaryDay.Instance();
                    break;
                case 'b':
                    if(everyELevelAtl5()) {
                        day = OrdinaryDay.Instance();
                        break;
                    }

                    day = BadDay.Instance();
                    break;
            }
        }

        public IDay getDay() {
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
            foreach(Animal a in animals) {
                if(a is Fish){
                    day.updateFish(a);
                }
                else if(a is Bird) {
                    day.updateBird(a);
                }
                else if(a is Dog) {
                    day.updateDog(a);
                }
            }
        }

        public List<Animal> getLowestELAnimals() {
            bool found = false;
            int i = 0;
            int lowestEL = 0;
            List<Animal> lowests = new List<Animal>();

            for (; i < animals.Count && !found; ++i) {
                if(animals[i].getExhilLevel() > 0){
                    lowestEL = animals[i].getExhilLevel();
                    lowests.Add(animals[i]);
                    found = true;
                }
            }
            
            if(!found) {
                throw new AllAnimalsDied();
            }

            for(; i < animals.Count; ++i) {
                if(animals[i].getExhilLevel() > 0 && animals[i].getExhilLevel() < lowestEL) {
                    lowests.Clear();
                    lowestEL = animals[i].getExhilLevel();
                    lowests.Add(animals[i]);
                }
                else if(animals[i].getExhilLevel() > 0 && animals[i].getExhilLevel() == lowestEL) {
                    lowests.Add(animals[i]);
                }
            }

            return lowests;
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