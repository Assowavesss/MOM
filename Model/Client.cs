using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public class Client : Actor
    {
        #region Properties
        public string Adress { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateFirstOrder { get; set; }
        #endregion

        #region Constructors
        public Client(string firstName, 
            string lastName,
            string adress,
            string phoneNumber) 
            : base(firstName,lastName)
        {
            Adress = adress;
            PhoneNumber = phoneNumber;
        }

        public Client(string firstName,
            string lastName,
            string adress,
            string phoneNumber,
            DateTime dateFirstOrder) 
            : this(firstName,
                  lastName,
                  adress, 
                  phoneNumber)
        {
            DateFirstOrder = dateFirstOrder;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString()
                + "\nAdress : " + Adress
                + "\nPhone Number" + PhoneNumber
                + "\nDate First Order" + DateFirstOrder.ToString();
                
        }

        public override void MessageReceived()
        {
            Console.WriteLine("Nous prenons en charge votre commande");
        }
        #endregion
    }
}
