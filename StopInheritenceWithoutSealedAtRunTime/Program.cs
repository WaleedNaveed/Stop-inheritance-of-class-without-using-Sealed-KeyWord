using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopInheritenceWithoutSealedAtRunTime
{
    class Program
    {
        public class Parent
        {
            public Parent()
            {
                if (this.GetType() == typeof(Parent))
                {
                    Console.WriteLine("Object of Parent class created successfully");
                }
                else
                {
                    throw new Exception("Runtime exception: Invalid operation, this 'Parent' class can not have any child, it does not support inheritence");
                }
            }
            public virtual void print()
            {
                Console.WriteLine("Parent class print method");
            }
        }

        public class Child : Parent
        {
            public override void print()
            {
                Console.WriteLine("Child class print method");
            }
        }



        static void Main(string[] args)
        {
            Parent parent;
            parent = new Child();

            parent.print();


            Console.ReadKey();
        }
    }
}
