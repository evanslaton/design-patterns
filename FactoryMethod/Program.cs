﻿using FactoryMethodPattern;
using FactoryMethodPattern.IngedientsFactories;
using FactoryMethodPattern.Pizzas;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //PizzaStore nyStore = new NYPizzaStore();
            //PizzaStore chicagoStore = new ChicagoPizzaStore();

            //Pizza pizza = nyStore.OrderPizza("cheese");
            //Console.WriteLine();
            //pizza = chicagoStore.OrderPizza("pepperoni");


            Pizza cheesePizza = new CheesePizza(new NYPizzaIngredientFactory());
            cheesePizza.Prepare();
        }
    }
}
