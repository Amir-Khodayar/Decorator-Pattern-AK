using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemo.Components
{
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Plain Pizza";
        }

        public double GetCost()
        {
            return 6.0;
        }

        public int GetSize(int Size)
        {
            return Size;
        }
    }
}