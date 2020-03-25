using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Surikat : Animal
    {

        public Surikat(int age, string name) : base(age, name)
        {
            this.Voice = "Hakuna Matata!";
        }
    }
}
