using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Dog : Animal
    {
        public Dog() { }

        public Dog(int age, string name) : base(age, name)
        {
            this.Voice = "WoofWoof";
        }
    }
}
