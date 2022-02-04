using System;
using System.Collections.Generic;
using System.Linq;


namespace Hw4
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Product product = new Product();

            List<string> invent_Main = product.invent;
            List<int> number_Main = product.number;
            List<double> price_Main = product.price;

            Inventory inventory = new Inventory();
            
            
            int whiletrue=0;

            while (whiletrue == 0)
            {

                Console.WriteLine("1 - Добавить продукт в инвентраь ");
                Console.WriteLine("2 - Удалить предмет из инвенторя ");
                Console.WriteLine("3 - Вывести инвентарь ");
                Console.WriteLine("4 - Exit ");
                Console.WriteLine("\n");
                string get_text = Console.ReadLine();
                Console.WriteLine("\n");


                switch (get_text)
                {
                    case "1":
                        Product.add(invent_Main, number_Main, price_Main);
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        Product.del(invent_Main, number_Main, price_Main);
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        Inventory.output_text(invent_Main, number_Main, price_Main);
                        Console.WriteLine("\n");
                        break;
                    case "4":
                        whiletrue = 2;
                        break;

                }
            }




        }

        
    }
}