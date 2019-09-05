using System;
using System.Collections;

namespace ForeachCast
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IEnumerable creater = new Creater();

            foreach(Child child in creater)
            {
                Console.WriteLine(child);
            }
        }
    }

    class Creater : IEnumerable
    {
        Child[] childArray;

        public Creater()
        {
            childArray = new Child[] {new Child(),new Child(),new Child(),new Child()};
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < childArray.Length; i++)
                yield return childArray[i];
        }
    }

    class Parent
    { }

    class Child:Parent
    { }
}
