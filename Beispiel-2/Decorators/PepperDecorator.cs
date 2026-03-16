using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Decorators
{
    public class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(IPizza pizza) : base(pizza)
        {

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + ", pepper";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 2.0;
        }
    }
}
}