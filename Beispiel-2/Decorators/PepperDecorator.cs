using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Decorators
{
    public class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return decoratedPizza.GetDescription() + ", pepper";
        }

        public override double GetCost()
        {
            return decoratedPizza.GetCost() + 2.0;
        }
    }
}
