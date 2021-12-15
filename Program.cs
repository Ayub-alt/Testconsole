using System;
using System.Collections.Generic;

namespace Consoletest
{
    class Program
    {

        private class Parent
            {
            public string name;// Имя отца

            public string[] childname=new string[10];// Массив для имена детей 
            public int[] childage =new int[10];// Массив для возраст детей
            public void children(int p)// Метод для получении инфо о детей
            {                
                int l = 0;
                for (int i=0;i<p;i++)//Loop для получения инфо о детей смотря на их число
                {
                    l++;
                    Console.Write("Введите имя {0}-го ребенка: ",l);
                    childname[i] = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите возраст {0}-го ребенка: ",l);
                    childage[i] = Convert.ToInt32(Console.ReadLine());
                }

                
            }
            //Метод для вывода полученнных значений
            public void GetChildren(string pname, string[] childname, int[] childage, int num)
            {
                int l = 0;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Имя родителя: " +pname);
                for(int i=0;i<num;i++)
                {
                    l++;
                    Console.WriteLine("Имя {0}-го ребенка: {1}, возраст: {2}", l, childname[i], childage[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Console.Write("Введите имя родителя: ");
            parent.name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите число детей: ");
            int childnumber = Convert.ToInt32(Console.ReadLine());

            if(childnumber==0)
            {
                Console.WriteLine("У {0} нет детей!!!", parent.name);
            }
            else if(childnumber>2)
            {
                Console.WriteLine(" Число детей не должно быть больше 2!");
            }
            else
            {
                parent.children(childnumber);
                parent.GetChildren(parent.name, parent.childname, parent.childage, childnumber);

            }

            Console.ReadKey();
        }
    }
}
