using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace task9 {
    public abstract class Animal {
        private string name;
        private int exhilLevel;

        protected Animal(string n, int el) {
            name = n;
            exhilLevel = el;
        }

        public string getName() {
            return name;
        }

        public int getExhilLevel() {
            return exhilLevel;
        }

        public void setExhilLevel(int el) {
            exhilLevel = el;
        }

        public override string ToString()
        {
            return "(" + GetType() + ", " + getName() + ", " + getExhilLevel() + ")" + " ";
        }
    }

    class Fish : Animal {
        public Fish(string n, int el) : base(n, el) { }
    }
    
    class Bird : Animal {
        public Bird(string n, int el) : base(n, el) { }
    }

    class Dog : Animal {
        public Dog(string n, int el) : base(n, el) { }
    }
}