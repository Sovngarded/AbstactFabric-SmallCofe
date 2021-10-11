using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it now? (A) - BREAKFAST (B) - LUNCH (C) - SUPPER");
            char input = Console.ReadKey().KeyChar;
            Menu factory;
            switch (input)
            {
                case 'A':
                    factory = new BreakfastFactory();
                    break;

                case 'C':
                    factory = new LunchFactory();
                    break;

                case 'B':
                    factory = new SupperFactory();
                    break;
                    

                default:
                    throw new NotImplementedException();

            }

            var mainmeal = factory.CreateMain();
            var salad = factory.CreateSalad();
            var dessert = factory.CreateDessert();
            var drink = factory.CreateDrink();

            Console.WriteLine("\nMain: " + mainmeal.GetType().Name);
            Console.WriteLine("\nSalad: " + salad.GetType().Name);
            Console.WriteLine("\nDessert: " + dessert.GetType().Name);
            Console.WriteLine("\nDrink: " + drink.GetType().Name);

            Console.ReadKey();
        }

         abstract class MainMenu { };
         abstract class Salad { };

         abstract class Dessert { };
         abstract class Drink { };


        abstract class Menu
        {
            public abstract MainMenu CreateMain();
            public abstract Salad CreateSalad();

            public abstract Dessert CreateDessert();

            public abstract Drink CreateDrink();
        }

        class Porrdige : MainMenu { }
        class Eggs : Salad { }
        class Pancake : Dessert { }
        class Coffee : Drink { }




        class BreakfastFactory : Menu
        {
            public override MainMenu CreateMain()
            {
                return new Porrdige();
            }

            public override Salad CreateSalad()
            {
                return new Eggs();
            }

            public override Dessert CreateDessert()
            {
                return new Pancake();
            }
            public override Drink CreateDrink()
            {
                return new Coffee();
            }


        }

        class Pasta : MainMenu { }
        class Vegies : Salad { }
        class Biscuit : Dessert { }
        class Compote : Drink { }




        class LunchFactory : Menu
        {
            public override MainMenu CreateMain()
            {
                return new Pasta();
            }

            public override Salad CreateSalad()
            {
                return new Vegies();
            }

            public override Dessert CreateDessert()
            {
                return new Biscuit();
            }
            public override Drink CreateDrink()
            {
                return new Compote();
            }


        }

        class Yougurt : MainMenu { }
        class Fruit : Salad { }
        class Cake : Dessert { }
        class Tea : Drink { }




        class SupperFactory : Menu
        {
            public override MainMenu CreateMain()
            {
                return new Yougurt();
            }

            public override Salad CreateSalad()
            {
                return new Fruit();
            }

            public override Dessert CreateDessert()
            {
                return new Cake();
            }
            public override Drink CreateDrink()
            {
                return new Tea();
            }


        }




    }
}
