using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Decorators
{
    public class Decorator : PizzaDecorator
    {
        public Tunaecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + ", Tuna";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 2.5;
        }
    }
}