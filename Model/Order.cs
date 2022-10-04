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
        #region Properties
        List<Pizza> Pizzas { get; set; }
        List<Boisson> Boissons { get; set; }
        #endregion

        #region Constructors
        public ItemsOrder(List<Pizza> pizzas, List<Boisson> boissons)
        {
            Pizzas = new List<Pizza>(pizzas);
            Boissons = new List<Boisson>(boissons);
        }
        #endregion

        #region Methods
        public double Price()
        {
            double priceRet = 0.0;
            Pizzas.ForEach(e => priceRet += e.Price);
            return priceRet;
        }

        public string Invoice()
        {
            return "Price : " + Price()
                + "\n" + ToString();
        }

        public override string ToString()
        {
            string pizzasOrder = "", boissonsOrder = "";

            Pizzas.ForEach(e => pizzasOrder += e.ToString() + ' ');
            Boissons.ForEach(e => boissonsOrder += e.ToString() + ' ');

            return pizzasOrder + "\n" + boissonsOrder;
        }
        #endregion
    }

    sealed class Order
    {
        #region Status
        public enum Status
        {
            Prepartion,
            Delivery,
            Delivered
        }
        #endregion

        #region Fields
       
        #endregion

        #region Properties
        public uint Number { get; set; }

        public DateTime OrderSchedule { get; set; }
        
        public string NameClient { get; set; } 

        public string NameClerk { get; set; }

        public ItemsOrder Items { get; set; }

        public Status State { get; set; }
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
            State = Status.Prepartion;
        }
        #endregion

        #region Method
        public void SendMessage(IActor actor)
        {
            actor.MessageReceived();
        }

        public string Invoice()
        {
            return Items.Invoice();
        }

        public DeliveryMan SendDeliveryMan(string adress)
        {
            State = Status.Delivery;
            return new DeliveryMan(this, adress);
        }

        public override string ToString()
        {
            return "Order Number : " + Number.ToString()
                + "\nSchedule Order : " + OrderSchedule.ToString()
                + "\nName of client : " + NameClient
                + "\nName of clerk : " + NameClerk
                + "\nItems : " + Items.ToString()
                + "\nState : " + State.ToString();
        }
        #endregion
    }
}
