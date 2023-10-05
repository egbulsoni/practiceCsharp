using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode
{
    internal class Person
    {
        public string name;
        public int weight;
        public static string species = "Human";
        public static int personCount = 0;

        public Person(string newName = "Bob", int newWeight = 150)
        {
            name = newName;
            weight = newWeight;
            personCount++;
        }

        public void Eat(int val)
        {
            weight += val;
        }

        public char FirstInitial()
        {
            return name[0];
        }
    }
}
