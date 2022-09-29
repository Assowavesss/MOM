using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public enum Boisson
    {
        Coca,
        Orangina,
        Sevenup
    }

    internal sealed class ItemsOrder
    {
        List<Pizza> Pizzas { get; set; }
        List<Boisson> Boissons { get; set; }

        public ItemsOrder(List<Pizza> pizzas, List<Boisson> boissons)
        {
            Pizzas = new List<Pizza>(pizzas);
            Boissons = new List<Boisson>(boissons);
        }


        public double Price
        {
            get
            {
                double priceRet = 0.0;
                Pizzas.ForEach(e => priceRet += e.Price);
                return priceRet;
            }
        }

        public override string ToString()
        {
            string pizzasOrder = "", boissonsOrder = "";

            Pizzas.ForEach(e => pizzasOrder += e.ToString() + ' ');
            Boissons.ForEach(e => boissonsOrder += e.ToString() + ' ');

            return pizzasOrder + "\n" + boissonsOrder;
        }
    }

    class Order
    {
        #region Properties
        public uint Number { get; set; }

        public DateTime OrderSchedule { get; set; }
        
        public string NameClient { get; set; }

        public string NameClerk { get; set; }

        public ItemsOrder Items { get; set; }
        #endregion


        #region Constructors
        public Order(uint number,
            DateTime orderSchedule,
            string nameClient, 
            string nameClerk,
            List<Pizza> pizzas,
            List<Boisson> boissons)
        {
            Number = number;
            OrderSchedule = orderSchedule;
            NameClient = nameClient;
            NameClerk = nameClerk;
            Items = new ItemsOrder(new List<Pizza>(pizzas),new List<Boisson>(boissons));
        }
        #endregion

        public void SendMessage(IActor actor)
        {
            actor.MessageReceived();
        }

        public string Invoice()
        {
            return this.ToString();
        }


        public override string ToString()
        {
            return "Order Number : " + Number.ToString()
                + "\nSchedule Order : " + OrderSchedule.ToString()
                + "\nName of client : " + NameClient
                + "\nName of clerk : " + NameClerk
                + "\nOrder detaisl : " + Items.ToString();
        }
    }
}
