using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub_Assign
{
    interface IQuittable //IQuittable interface (not a class) these are always public no need to add. 
    {
        void Quit(Person person); //method added into IQuittable
    }
}
