using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Decorators
{
    public class TunaDecorator : PizzaDecorator
    {
        public TunaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return decoratedPizza.GetDescription() + ", Tuna";
        }

        public override double GetCost()
        {
            return decoratedPizza.GetCost() + 2.5;
        }
    }
}