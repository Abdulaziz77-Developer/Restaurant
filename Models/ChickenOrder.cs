using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ChickenOrder
    {
        private int quantity;
        public ChickenOrder(int _quantity)
        {
            quantity = _quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }

        public void Cook()
        {

        }
        public void Cutup()
        {

        }
    }
}
