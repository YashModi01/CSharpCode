using System;
using System.Collections.Generic;
using System.Text;

namespace Newproject
{
    class ItalianChef : Chef
    {
        public override void Makepizza()
        {
            Console.WriteLine("Italian Chef makes Cheese Pizza");
        }

        public void Makepasta()
        {
            Console.WriteLine("Italian Chef makes pasta");
        }
    }
}
