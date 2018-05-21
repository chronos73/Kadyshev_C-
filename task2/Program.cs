using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> list_name = new Dictionary<string, string>();
            String tmp_name = "", name = "";
            int i = 0;
            while (list_name.Count != 4)
            {

                Console.Write("Введите имя игрока #{0}: ", i + 1);
                name = Console.ReadLine();
                if (name != tmp_name)
                {
                    list_name.Add(name, "");
                }
                else
                {
                    Console.WriteLine("Даное имя уже занято, введите другое");
                    continue;
                }
                i++;
                tmp_name = name;
            }
            foreach (var item in list_name)
            {
                Console.WriteLine("Имя:{0}", item.Key);
            }
            Console.ReadKey();
        }
    }
}
