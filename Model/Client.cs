using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public class Client : Actor
    {
        
        public string Name { get; set; }
        
        Client()
        {
            base.IsReceived = false;
        }

        public override void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre command");
        }
    }
}
