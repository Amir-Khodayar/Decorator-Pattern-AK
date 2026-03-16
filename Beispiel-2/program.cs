using System;
using System.Net.Http.Headers;
using DecoratorPatternDemo.Components;
using DecoratorPatternDemoPizza.Components;
using DecoratorPatternDemoPizza.Decorators;
using DecoratorPatternDemoPizza.Interfaces;

class Program
{
    static void Main()
    {
        IPizza pizza = new PlainPizza();
        pizza = new PizzaDecorator(pizza);
        pizza = new pepperDecorator(pizza);

    }
}