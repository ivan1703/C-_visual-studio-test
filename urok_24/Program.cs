//в 24 уроке учим перечисления enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok_24
{
    enum breat {Dog,cat,bird,bear,Tiger};
    class Animal {
        public breat breat;
       public Animal(breat breat){
            this.breat = breat;
        }
        public void print() {
            Console.WriteLine(breat);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(breat.cat);
            dog.print();
            Console.ReadKey();

        }
    }
}
