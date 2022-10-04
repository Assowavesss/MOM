using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    class DeliveryMan : Actor
    {

        #region Properties
        public Order Ord{ get; set; }

        public string Adress { get; set; }
        #endregion

        public DeliveryMan(Order ord,string adress)
        {
            Ord = ord;
            Adress = adress;
        }



        public override void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre command");
        }
    }
}
