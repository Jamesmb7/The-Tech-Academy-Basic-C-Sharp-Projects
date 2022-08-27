using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub_Assign
{
    public abstract class Person //makes this class public and abstract (cannot be instantiated)
    {
        public string firstName { get; set; } //property called firstName
        public string lastName { get; set; } //property called lastName

        public abstract void SayName(); //abstract method SayName();
        
    }
}
