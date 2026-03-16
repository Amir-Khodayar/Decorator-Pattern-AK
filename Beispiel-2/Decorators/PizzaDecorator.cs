using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza decoratedPizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.decoratedPizza = pizza;
        }

        public virtual string GetDescription()
        {
            return decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }

        public virtual double GetSize() {

            return decoratedPizza.GetSize();
    }
}