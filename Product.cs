using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    public class Product
    {
        public List<string> invent = new List<string>();
        public List<int> number = new List<int>();
        public List<double> price = new List<double>();




        public static void add(List<string> invent, List<int> number, List<double> price)
        {
            Console.WriteLine("Какой продукт вы хоите довабить в инвентарь: ");
            string add_product = Console.ReadLine();
            invent.Add(add_product);

            int whileTest = 0;

            while (whileTest == 0)
            {
                Console.WriteLine("Сколько вы хотите добавить: ");
                string test_number = Console.ReadLine();
                int add_number;
                if (int.TryParse(test_number, out add_number))
                {
                    number.Add(add_number);
                    whileTest = 1;
                }
                else
                {
                    Console.WriteLine("\nТакое вводить нельзя\n");

                }
            }

            while (whileTest==1)
            {


                Console.WriteLine("По какой цене ваш продукт: ");
                string test_price = Console.ReadLine();
                double add_price;
                if (double.TryParse(test_price, out add_price))
                {
                    price.Add(add_price);
                    whileTest = 2;
                }
                else
                {
                    Console.WriteLine("\nТакое вводить нельзя\n");

                }
            }



        }

        public static void del(List<string> invent, List<int> number, List<double> price)
        {
            Console.WriteLine("Какой продук вы хотите удалить из инвенторя: ");
            string del_product = Console.ReadLine();
            var mess = invent.IndexOf(del_product);
            invent.RemoveAt(mess);
            number.RemoveAt(mess);
            price.RemoveAt(mess);



        }
    }
}
