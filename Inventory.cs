using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    public class Inventory: Product
    {
        


        public static void output_text(List<string> invent, List<int> number, List<double> price)
        {
            

            Console.WriteLine("Ваш инвентраь \n");

            for (int i = 0; i < invent.Count; i++)
            {
                Console.WriteLine($"{invent[i]}-{price[i]}$ его количество:{number[i]} \n");
                Console.WriteLine($"Сумма вашего инвентаря:{sum(price)}\n");

            }

        }

        public static double sum(List<double> price)
        {
            double sum = 0;
            for (int i = 0;i < price.Count;i++)
            {
                sum+=price[i];

            }
            return sum;
        }




    }


}





