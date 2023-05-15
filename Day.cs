using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    abstract class Day {
        protected Day() {}
        public virtual void updateFish(Animal a) {}
        public virtual void updateBird(Animal a) {}
        public virtual void updateDog(Animal a) {}
    }

    class GoodDay : Day {
        private static GoodDay instance;
        private GoodDay() {}

        public static GoodDay Instance() {
            if(instance == null) {
                instance = new GoodDay();
            }

            return instance;
        }

        public override void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 1);
        }

        public override void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 2);
        }

        public override void updateDog(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 3);
        }
    }

    class OrdinaryDay : Day {
        private static OrdinaryDay instance;
        private OrdinaryDay() {}

        public static OrdinaryDay Instance() {
            if(instance == null) {
                instance = new OrdinaryDay();
            }

            return instance;
        }

        public override void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        public override void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 1);
        }

        public override void updateDog(Animal a) { }
    }

    class BadDay : Day {
        private static BadDay instance;
        private BadDay() {}

        public static BadDay Instance() {
            if(instance == null) {
                instance = new BadDay();
            }

            return instance;
        }

        public override void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 5);
        }

        public override void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        public override void updateDog(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 10);
        }
    }
}