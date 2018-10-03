using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pets;

namespace Pet1
{
    public class Pet
    {
        public double weight;
        public string type, name, owner;

        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string getTag()
        {
            string tag = $"If lost, call {this.owner}";
            return tag;
        }

    }
}