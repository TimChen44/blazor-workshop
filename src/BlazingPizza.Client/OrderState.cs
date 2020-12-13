using System.Collections.Generic;

namespace BlazingPizza.Client
{
    public class OrderState
    {
        public Order Order { get; private set; } = new Order();

        public Pizza CreateConfigurePizza(PizzaSpecial special)
        {
            return new Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>(),
            };
        }

        public void AddConfigurePizza(Pizza configuringPizza)
        {
            Order.Pizzas.Add(configuringPizza);
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}
