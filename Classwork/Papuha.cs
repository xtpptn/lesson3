using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Papuha : Animal
    {
        public Papuha(int age, string name) : base(age, name)
        {
            this.Voice = "Privet, ptichka!";
        }
}
}
