using System;

namespace _21._12Homework1
{
    internal class Datatime
    {
        private int v1;
        private int v2;
        private int v3;

        public Datatime(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public static object Now { get; internal set; }
        public int Year { get; internal set; }

        internal object ToString(string v)
        {
            throw new NotImplementedException();
        }
    }
}