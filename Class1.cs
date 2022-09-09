using System;

namespace SubProject2
{
    public class Class1
    {
        private string elses;
        public Class1()
        {
            elses = "Sub2";
            Console.WriteLine(elses);
        }

        public void Sub2()
        {
            elses = "Sub2 EXT";
            Console.WriteLine(elses);
        }
    }
}
