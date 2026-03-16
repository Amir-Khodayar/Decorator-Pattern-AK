using System;
using System.Net.Http.Headers;
using DecoratorPatternDemoPizza.Components;
using DecoratorPatternDemoPizza.Decorators;
using DecoratorPatternDemoPizza.Interfaces;

class Program
{
    static void Main()
    {
        IPizza pizza = new PlainPizza();
        pizza = new PepperDecorator(pizza);
        pizza = new TunaDecorator(pizza);
        Console.WriteLine(pizza.GetDescription());
        Console.WriteLine(pizza.GetCost());
        
    }
}