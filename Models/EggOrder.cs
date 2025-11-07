using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class EggOrder
    {
        public int quantity;
        public static int? quality;
        private static Random rand = new Random();
        public EggOrder(int _quantity)
        {
            quantity = _quantity;
            quality = rand.Next(0, 100);
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public static  int? GetQuality()
        {
            if (quality<=25)
            {
                throw new Exception("The Egg Is Rotten");
            }
            return quality;
        }

        public void DisCardShell()
        {

        }
        public void Cook()
        {

        }
        public void Crack()
        {

        }
    }
}
