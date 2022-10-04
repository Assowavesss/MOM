using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    class Pizza
    {
        public enum Size
        {
            Small,
            Middle,
            Long
        }

        public enum Kind
        {
            Ketchup,
            Barbecue,
            Vegan,
            FourCheeses
        }

        public Size Sz { get ; set; }

        public Kind Kd { get; set; }

        public double Price { get; set; }

        public Pizza(Size sz, Kind kd, double price)
        {
            Sz = sz;
            Kd = kd;
            Price = price;
        }

        public override string ToString()
        {
            return '(' + Sz.ToString() + ',' + Kd.ToString() + ',' + Price.ToString() + ')';
        }
    }
}
