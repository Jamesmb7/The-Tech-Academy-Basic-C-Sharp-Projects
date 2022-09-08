using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway //interface is always public no need to add it to interfaces.
    {
        void WalkAway(Player player);
    }
}
