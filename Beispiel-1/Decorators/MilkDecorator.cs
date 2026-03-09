using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.5;
        }
    }
}