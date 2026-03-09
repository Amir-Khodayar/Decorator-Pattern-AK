using DecoratorPatternDemo.Components;
using DecoratorPatternDemo.Decorators;
using DecoratorPatternDemo.Interfaces;

class Program
{
    static void Main()
    {
        ICoffee coffee = new PlainCoffee();

        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine("Order: " + coffee.GetDescription());
        Console.WriteLine("Total Cost: " + coffee.GetCost());
    }
}