using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace task9 {
    abstract class Day {
        public virtual bool isGood() {
            return false;
        }

        public virtual bool isOrdinary() {
            return false;
        }

        public virtual bool isBad() {
            return false;
        }
    }

    class goodDay : Day {
        public bool isGood() {
            return true;
        }
    }

    class ordinaryDay : Day {
        public bool isOrdinary() {
            return true;
        }
    }
    class badDay : Day {
        public bool isBad() {
            return true;
        }
    }
}