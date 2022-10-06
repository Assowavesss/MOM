using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    class Kitchen : IActor
    {
        public void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre command");
        }
    }
}
