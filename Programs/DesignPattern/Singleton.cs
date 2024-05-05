using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.DesignPattern
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private Singleton() { } 
        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do Something");
        }
    }
}
