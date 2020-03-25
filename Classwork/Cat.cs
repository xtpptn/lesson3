using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Cat : Animal
    {
        public Cat(int age, string name) : base(age, name)
        {
            this.Voice = "MewMew";
        }
    }
}
