﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet1;
using Pets;
namespace Cat1
{
    public class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base("cat", name, owner, weight)
        {

        }

        public string meow(int count)
        {
            string meow = null;
            for (int i = 0; i < count; i++)
                meow = meow + "Meow.";
            return meow;
        }
    }
}