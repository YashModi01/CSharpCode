using System;
using System.Collections.Generic;
using System.Text;

namespace Newproject
{
    class Chef
    {
        public virtual void Makepizza()
        {
            Console.WriteLine("The Chef makes pizza");
        }

        public void Makesalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
    }
}
