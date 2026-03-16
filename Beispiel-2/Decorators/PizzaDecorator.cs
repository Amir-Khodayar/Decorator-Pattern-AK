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
            return decoratedPizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedPizza.GetCost();
        }

        public virtual int GetSize()
        {

            return decoratedPizza.GetSize();
        }
    }
}