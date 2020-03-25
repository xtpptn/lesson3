using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    public class Animal
    {
        
        public Animal() 
        {
            Console.WriteLine("Hesher ne tak uz vinovat.");
        }

        public Animal(int age, string name) 
        {
            this.Age = age;
            this.Name = name;

        }

        public virtual void Jump()
        {
            Console.WriteLine("Hop!");
        }

        /*public string GetVoice()
        {
            return this.Voice;
        }*/

        public string Voice { get; protected set; } = "Day Pivko";

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name}:{this.Name} age is {this.Age} voice is {this.Voice}";
        }
        /*public void GrowAge ()
        {
            this.Age++;
        }*/

    }
}
