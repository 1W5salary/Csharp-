using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01
{
    internal abstract class AirDefener
    {
        internal abstract void fire();
        
    }

    internal class Air:AirDefener
    {
        internal override void fire()
        {
            Console.WriteLine("air fire!!!");
        }
    }

    class Tank : AirDefener
    {
        internal override void fire()
        {
            Console.WriteLine("tank fire!!!");
        }
    }
}
