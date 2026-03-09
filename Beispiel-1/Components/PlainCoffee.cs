using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.Components
{
    public class PlainCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }

        public double GetCost()
        {
            return 2.0;
        }
    }
}