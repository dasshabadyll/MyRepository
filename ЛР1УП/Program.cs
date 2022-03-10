using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int menu = 0;
                List<Lake> counts = new List<Lake>();
                do
                {
                    Console.WriteLine("1. Добавить реку");
                    Console.WriteLine("2. Просмотреть реку");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Введите название реки:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите площадь бассейна:");
                            double area = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите протяженность:");
                            double length = Convert.ToDouble(Console.ReadLine());
                            counts.Add(new Lake(name, area, length));
                            break;
                        case 2:
                            Console.Write("Река");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Name);
                            }
                            Console.WriteLine();
                            Console.Write("Площадь бассейна");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Area);
                            }
                            Console.WriteLine();
                            Console.Write("Протяженность");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Length);
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (menu < 3);
                Console.ReadKey();
            }
            catch { }
        }
    }
}
