using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Elephant : Animal
    {
        public Elephant(int age, string name) : base(age, name)
        {
            this.Voice = "FUUUUUUUUUUUUUUUR";
        }

        public override void Jump()
        {
            Console.WriteLine("Make elephant small");
            base.Jump();
            Console.WriteLine("Make elephant great again");
        }

    }
}
