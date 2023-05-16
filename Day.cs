using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    interface IDay {
        void updateFish(Animal a);
        void updateBird(Animal a);
        void updateDog(Animal a);
    }

    class GoodDay : IDay {
        private static GoodDay instance;
        private GoodDay() {}

        public static GoodDay Instance() {
            if(instance == null) {
                instance = new GoodDay();
            }

            return instance;
        }

        public void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 1);
        }

        public void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 2);
        }

        public void updateDog(Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 3);
        }
    }

    class OrdinaryDay : IDay {
        private static OrdinaryDay instance;
        private OrdinaryDay() {}

        public static OrdinaryDay Instance() {
            if(instance == null) {
                instance = new OrdinaryDay();
            }

            return instance;
        }

        public void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        public void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 1);
        }

        public void updateDog(Animal a) { }
    }

    class BadDay : IDay {
        private static BadDay instance;
        private BadDay() {}

        public static BadDay Instance() {
            if(instance == null) {
                instance = new BadDay();
            }

            return instance;
        }

        public void updateFish(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 5);
        }

        public void updateBird(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        public void updateDog(Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 10);
        }
    }
}