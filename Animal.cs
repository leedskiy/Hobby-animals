using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    abstract class Animal {
        private string name;
        private int exhilLevel;

        public Animal(string n, int el) {
            name = n;
            exhilLevel = el;
        }

        public string getName() {
            return name;
        }

        public void setName(string n) {
            name = n;
        }

        public int getExhilLevel() {
            return exhilLevel;
        }

        public void setExhilLevel(int el) {
            exhilLevel = el;
        }

        public virtual void updateExhilLevel(Day day) {}
    }

    class Fish : Animal {
        private static Fish instance;

        public static Fish Instance()
        {
            if (instance == null)
            {
                instance = new Fish();
            }

            return instance;
        }

        public override void updateExhilLevel(Day day) {
            if(day.isGood()) {
                setExhilLevel(getExhilLevel() + 1);
            }
            else if(day.isOrdinary()) {
                setExhilLevel(getExhilLevel() - 3);
            }
            else if(day.isBad()) {
                setExhilLevel(getExhilLevel() - 5);
            }
        }
    }
    
    class Bird : Animal {
        private static Bird instance;

        public static Bird Instance()
        {
            if (instance == null)
            {
                instance = new Bird();
            }

            return instance;
        }

        public override void updateExhilLevel(Day day) {
            if(day.isGood()) {
                setExhilLevel(getExhilLevel() + 2);
            }
            else if(day.isOrdinary()) {
                setExhilLevel(getExhilLevel() - 1);
            }
            else if(day.isBad()) {
                setExhilLevel(getExhilLevel() - 3);
            }
        }
    }

    class Dog : Animal {
        private static Dog instance;

        public static Dog Instance()
        {
            if (instance == null)
            {
                instance = new Dog();
            }

            return instance;
        }

        public override void updateExhilLevel(Day day) {
            if(day.isGood()) {
                setExhilLevel(getExhilLevel() + 3);
            }
            else if(day.isOrdinary()) {
            }
            else if(day.isBad()) {
                setExhilLevel(getExhilLevel() - 10);
            }
        }
    }
}