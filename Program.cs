using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp225
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Выберите: стэк или очередь?");
            Console.WriteLine("Введите 1 для стека");
            Console.WriteLine("Введите 2 для очереди");
            string a = Console.ReadLine();
            Console.WriteLine("Выберите: строка или цифра?");
            Console.WriteLine("Введите 1 для цифры");
            Console.WriteLine("Введите 2 для строки");
            string h = Console.ReadLine();
            try
            {

                if (a == "1")
                {
                    if (h == "1")
                    {
                       List<int> wq = new List<int>();
                        Console.WriteLine("Заполните стэк. Введите *, для того чтобы завешить заполнение");
                        string u = Console.ReadLine();
                        while (u != "*")
                        {
                            wq.Add(int.Parse(u));
                            u = Console.ReadLine();
                        }
                        stek(wq);
                    }
                    if (h == "2")
                    {
                        List<string> wq = new List<string>();
                        Console.WriteLine("Заполните стэк. Введите *, для того чтобы завешить заполнение");
                        string u = Console.ReadLine();
                        while (u != "*")
                        {
                            wq.Add(u);
                            u = Console.ReadLine();
                        }
                        stek1(wq);
                    }
                }
                if (a == "2")
                {
                    if (h == "1")
                    {
                        List<int> wq = new List<int>();
                        Console.WriteLine("Заполните очередь. Введите *, для того чтобы завешить заполнение");
                        string u = Console.ReadLine();
                        while (u != "*")
                        {
                            wq.Add(int.Parse(u));
                            u = Console.ReadLine();
                        }
                        ocheted(wq);
                    }
                    if (h == "2")
                    {
                        List<string> wq = new List<string>();
                        Console.WriteLine("Заполните очередь. Введите *, для того чтобы завешить заполнение");
                        string u = Console.ReadLine();
                        while (u != "*")
                        {
                            wq.Add(u);
                            u = Console.ReadLine();
                        }
                        ocheted1(wq);
                    }
                }
            }
            catch
            {
                Console.WriteLine("При выполнении были введены неверные данные");
            }

            Console.ReadKey();

        }
        static public List<T> stek(List<int> a)
        {
            Console.WriteLine("Выберите действе со стеком");
            int b = 1;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Введите 1 для добавления");
                Console.WriteLine("Введите 2 для удаления");
                Console.WriteLine("ВВедите 3 для просмотра");
                string heh = Console.ReadLine();

                if (heh == "1")
                {
                    Console.WriteLine("Введите число для добавления в стэк");
                    a.Add(int.Parse(Console.ReadLine()));
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[a.Count - z - 1]);
                    }
                    Console.WriteLine("Начало");
                }
                if (heh == "2")
                {
                    if (a.Count >= 1)
                    {
                        Console.WriteLine("Было удалено последнее число в стэке");
                    
                        a.RemoveAt(a.Count - 1);
                        for (int z = 0; z < a.Count; z++)
                        {
                            Console.WriteLine(a[a.Count - z - 1]);
                        }
                        Console.WriteLine("Начало");
                    }
                    else { Console.WriteLine("Стэк пуст"); }
                }
                if (heh == "3")
                {
                    Console.WriteLine("Стэк");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[a.Count - z - 1]);
                    }
                    Console.WriteLine("Начало");
                }
                Console.WriteLine("Повторить?");
                Console.WriteLine("1 Да");
                Console.WriteLine("2 Нет");
                string cnce = Console.ReadLine();
                if (cnce == "1")
                {
                    b = b + 1;
                }
            }
            return a;
        }
        static public List<string> stek1(List<string> a)
        {
            Console.WriteLine("Выберите действе со стеком");
            int b = 1;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Введите 1 для добавления");
                Console.WriteLine("Введите 2 для удаления");
                Console.WriteLine("ВВедите 3 для просмотра");
                string heh = Console.ReadLine();

                if (heh == "1")
                {
                    Console.WriteLine("Введите число для добавления в стэк");
                    a.Add(Console.ReadLine());
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[a.Count - z - 1]);
                    }
                    Console.WriteLine("Начало");
                }
                if (heh == "2")
                {
                    if (a.Count >= 1)
                    {
                        Console.WriteLine("Было удалено последнее число в стэке");
                    a.RemoveAt(a.Count - 1);
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[a.Count - z - 1]);
                    }
                    Console.WriteLine("Начало");
                }
                else { Console.WriteLine("Стэк пуст"); }
            }
                if (heh == "3")
                {
                    Console.WriteLine("Стэк");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[a.Count - z - 1]);
                    }
                    Console.WriteLine("Начало");
                }
                Console.WriteLine("Повторить?");
                Console.WriteLine("1 Да");
                Console.WriteLine("2 Нет");
                string cnce = Console.ReadLine();
                if (cnce == "1")
                {
                    b = b + 1;
                }
            }
            return a;
        }
        static public List<int> ocheted(List<int> a)
        {
            Console.WriteLine("Выберите действе с очередью");
            int b = 1;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Введите 1 для добавления");
                Console.WriteLine("Введите 2 для удаления");
                Console.WriteLine("ВВедите 3 для просмотра");
                string heh = Console.ReadLine();

                if (heh == "1")
                {
                    Console.WriteLine("Введите число для добавления в очередь");
                    a.Add(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }
                }
                if (heh == "2")
                {
                    if (a.Count >= 1)
                    {
                        Console.WriteLine("Было удалено первое число в очереди");
                    a.RemoveAt(0);
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }
                    }
                    else { Console.WriteLine("Очередь пуста"); }
                }
                if (heh == "3")
                {
                    Console.WriteLine("Очередь");
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }
                    
                }
                Console.WriteLine("Повторить?");
                Console.WriteLine("1 Да");
                Console.WriteLine("2 Нет");
                string cnce = Console.ReadLine();
                if (cnce == "1")
                {
                    b = b + 1;
                }
            }
            return a;
        }
        static public List<string> ocheted1(List<string> a)
        {
            Console.WriteLine("Выберите действе с очередью");
            int b = 1;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Введите 1 для добавления");
                Console.WriteLine("Введите 2 для удаления");
                Console.WriteLine("ВВедите 3 для просмотра");
                string heh = Console.ReadLine();

                if (heh == "1")
                {
                    Console.WriteLine("Введите число для добавления в очередь");
                    a.Add(Console.ReadLine());
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }
                }
                if (heh == "2")
                {
                    if (a.Count >= 1)
                    {
                        Console.WriteLine("Было удалено первое число в очереди");
                    a.RemoveAt(0);
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }
                    }
                    else { Console.WriteLine("Очередь пуста"); }
                }
                if (heh == "3")
                {
                    Console.WriteLine("Очередь");
                    Console.WriteLine("Начало");
                    for (int z = 0; z < a.Count; z++)
                    {
                        Console.WriteLine(a[z]);
                    }

                }
                Console.WriteLine("Повторить?");
                Console.WriteLine("1 Да");
                Console.WriteLine("2 Нет");
                string cnce = Console.ReadLine();
                if (cnce == "1")
                {
                    b = b + 1;
                }
            }
            return a;
        }
    }
}
