using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet1;
using Pets;
namespace Dog1
{
    public class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base("dog", name, owner, weight)
        {

        }

        public string bark(int count)
        {
            string bark = null;
            for (int i = 0; i < count; i++)
                bark = bark + "bark!";
            return bark;
        }
    }
}