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

        public string DeliveryAdress { get; set; }
        #endregion

        public DeliveryMan(string firstName, string lastName ) : base(firstName,lastName )
        {
            
           
        }

        public override void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre command");
        }
    }
}
