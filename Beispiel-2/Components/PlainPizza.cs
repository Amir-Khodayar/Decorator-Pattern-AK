using DecoratorPatternDemoPizza.Interfaces;

namespace DecoratorPatternDemoPizza.Components
{
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Plain Pizza";
        }

        public int GetSize()
        {
           return 23;
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