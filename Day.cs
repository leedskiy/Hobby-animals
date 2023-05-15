using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    abstract class Day {
        protected Day() {}
        protected virtual void updateExhilLevel(ref List<Animal> ans) {}
        protected virtual void updateFish(ref Animal a) {}
        protected virtual void updateBird(ref Animal a) {}
        protected virtual void updateDog(ref Animal a) {}
    }

    class GoodDay : Day {
        private static goodDay instance;
        private goodDay() {}

        public static goodDay Instance() {
            if(instance == null) {
                instance = new goodDay();
            }

            return instance;
        }

        private override void updateFish(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 1);
        }

        private override void updateBird(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 2);
        }

        private override void updateDog(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() + 3);
        }

        public override void updateExhilLevel(ref List<Animal> ans) {
            foreach (Animal a in ans) {
                if(a is Fish){
                    updateFish(ref a);
                }
                else if(a is Bird) {
                    updateBird(ref a);
                }
                else if(a is Dog) {
                    updateDog(ref a);
                }
            }
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

        private override void updateFish(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        private override void updateBird(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 1);
        }

        private override void updateDog(ref Animal a) { }

        public override void updateExhilLevel(ref List<Animal> ans) {
            foreach (Animal a in ans) {
                if(a is Fish){
                    updateFish(ref a);
                }
                else if(a is Bird) {
                    updateBird(ref a);
                }
                else if(a is Dog) {
                    updateDog(ref a);
                }
            }
        }
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

        private override void updateFish(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 5);
        }

        private override void updateBird(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 3);
        }

        private override void updateDog(ref Animal a) {
            a.setExhilLevel(a.getExhilLevel() - 10);
        }

        public override void updateExhilLevel(ref List<Animal> ans) {
            foreach (Animal a in ans) {
                if(a is Fish){
                    updateFish(ref a);
                }
                else if(a is Bird) {
                    updateBird(ref a);
                }
                else if(a is Dog) {
                    updateDog(ref a);
                }
            }
        }
    }

   


}