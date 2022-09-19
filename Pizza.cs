using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Pizza
    {
        public string Content { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{Content}\n--------------------------\nTotal Price: ${Price.ToString("#.##")}";
        }
    }
    static class ExtensionPizza
    {
        /// <summary>
        /// DataType must be Pizza as u changes the content of the Master class Pizza
        /// so the reciever has to be Pizza
        /// when u calls the method this part (this Pizza value) does not appear
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns>u returns the Same datatype of Pizza</returns>
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough X $4.00";
            value.Price += 4m;
            return value;
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"\nTomato Sauce X $2.00";
            value.Price += 2m;
            return value;
        }
        public static Pizza AddCheese(this Pizza value, bool extra)
        {
            value.Content += $"\n{(extra ? "Extra" : "Regular")} Cheese X ${(extra ? "4.00" : "2.00")}";
            value.Price += (extra ? 4m : 2m);
            return value;
        }
        public static Pizza AddToppings(this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} X ${price.ToString("#.##")}";
            value.Price += price;
            return value;
        }
    }
}
