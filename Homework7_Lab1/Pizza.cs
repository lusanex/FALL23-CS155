using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Lab1
{
    using System;

    public class Pizza
    {
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        // Constructor
        public Pizza(string size, int cheese, int pepperoni, int ham)
        {
            this.size = size;
            cheeseToppings = cheese;
            pepperoniToppings = pepperoni;
            hamToppings = ham;
        }

        // Getter and Setter for Size
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        // Getter and Setter for CheeseToppings
        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        // Getter and Setter for PepperoniToppings
        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        // Getter and Setter for HamToppings
        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

        // CalculateCost method
        public double CalculateCost()
        {
            double basePrice = size switch
            {
                "small" => 10,
                "medium" => 12,
                "large" => 14,
                _ => 0
            };
            int totalToppings = cheeseToppings + pepperoniToppings + hamToppings;
            return basePrice + (totalToppings * 2);
        }

        // ToString method
        public override string ToString()
        {
            return $"Size: {size}, Cheese: {cheeseToppings}, Pepperoni: {pepperoniToppings}, Ham: {hamToppings}, Total Cost: ${CalculateCost()}";
        }
    }
}
