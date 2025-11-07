using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Restaurant.Models
{
    public class Employee
    {
        private object? order;
        public int counterForGet = 1;
        public object NewRequest(int quantity , string text)
        {
            if (counterForGet==1 || counterForGet == 2)
            {
                if (text == "Egg")
                {
                    this.order = new EggOrder(quantity);
                }
                else
                {
                    this.order = new ChickenOrder(quantity);
                }
                counterForGet++;
            }
            else
            {
                if (string.Equals(text,"Egg"))
                {
                    this.order = new ChickenOrder(quantity);
                }
                else
                {
                    this.order = new EggOrder(quantity);
                }
                counterForGet = 1;
            }
                return order;
        }
        public string Inspect(object order)
        {
            if (order is ChickenOrder)
            {
                return "The Chicken is Ripe ";
            }
            else if(order is EggOrder)
            {
                return $"The Egg is Cooking {((EggOrder)order).GetQuantity()}";
            }
            else
            {
                throw new ArgumentNullException("Order cannot be null");
            }
        }
        public object CopyWithRequest()
        {
            if (order == null)
            {
                throw new ArgumentNullException("The employee has no request to  copy");
            }
            else if( order is EggOrder)
            {
                int qunatity = ((EggOrder)order).GetQuantity();
                return new EggOrder(qunatity);
            }
            else
            {
                int qunatity = ((ChickenOrder)order).GetQuantity();
                return new ChickenOrder(qunatity);
            }
        }
        public string PrepareFood()
        {
            if(order == null)
            {
                throw new ArgumentNullException("Order Cannot be null");
            }
            else if(order is EggOrder)
            {
                for (int i = 1; i < ((EggOrder)order).GetQuantity(); i++)
                {
                    ((EggOrder)order).DisCardShell();
                    ((EggOrder)order).Crack();
                    
                }
                ((EggOrder)order).Cook();
                return $"The Egg is Cooked {(EggOrder.GetQuality() > 25 ? "Egg is not Rotter" : "The Egg Is Rotten") }";
            }
            else
            {
                for (int i = 1; i < ((ChickenOrder)order).GetQuantity(); i++)
                {
                    ((ChickenOrder)order).Cutup();
                }
                ((ChickenOrder)order).Cook();
                return "The Chicken is Cooked";
            }
        }
    }
}
