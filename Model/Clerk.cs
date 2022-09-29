using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    class Clerk : Actor
    {
        public override void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre command");
        }
    }
}
