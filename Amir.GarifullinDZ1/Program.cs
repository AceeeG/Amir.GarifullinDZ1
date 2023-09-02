using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Amir.GarifullinDZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание, проверка умения выводить строки");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");

            Console.WriteLine("2 задание, тоже проверка умения выводить и немного думать");
            Console.WriteLine("Введите первое число:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string number2 = Console.ReadLine();
            Console.WriteLine("{0} , {1}", number2, number1);

            Console.WriteLine("3 задание, умение делать мат. операции и пользоваться модулем Math");
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double len = 2 * radius * Math.PI;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Длина окружности круга с радиусом {0} равна {1}, а площадь равна {2}", radius, len, area);
            
            Console.WriteLine("4 задание, модуль Math");
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Косинус {0} = {1}", x, Math.Cos(x));

            Console.WriteLine("5 задание, немного математики и условий(if, else)");
            Console.WriteLine("Введите первый коэфицент:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй коэфицент:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий коэфицент:");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(b, 2) - (4 * a * c);
            if(D == 0)
                {
                double xx = (b * (-1)) / 2;
                Console.WriteLine("Имеется один корень, равен {0}", xx);
                }
            else if (D > 0)
            {
                double x1 = (b * (-1) + Math.Sqrt(D)) / 2;
                double x2 = (b * (-1) - Math.Sqrt(D)) / 2;
                Console.WriteLine("Имеется два корня, первый равен {0}, второй равен {1}", x1, x2);
                Console.WriteLine(D);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }

            Console.WriteLine("6 задание, назначение уже имеющихся значений новым переменым");
            Console.WriteLine("Введите число a:");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int bb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            int cc = Convert.ToInt32(Console.ReadLine());

            int a1 = bb;
            int b1 = cc;
            int c1 = aa;
            Console.WriteLine("Теперь а = {0}, b = {1}, c = {2}", a1, b1, c1);
            int a2 = c1;
            int b2 = a1;
            int c2 = b1;
            Console.WriteLine("А теперь а = {0}, b = {1}, c = {2}", a2, b2, c2);

            Console.WriteLine("7 задание, модуль random");
            Random rnd = new Random();
            
            int num1 = rnd.Next();
            int num2 = rnd.Next();
            int num3 = rnd.Next();
            int num4 = rnd.Next();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            Console.WriteLine("8 задание, срезы работа со строками");
            string numb1 = Console.ReadLine();
            Console.WriteLine(numb1[2] + numb1.Remove(2));

            Console.WriteLine("9 задание, простые арифм. операции");
            Console.WriteLine("Введите стоимость конфет за 1 кг");
            int sweet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость печенья за 1 кг");
            int cookies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость яблок за 1 кг");
            int apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько килограмм конфет:");
            int sweetweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько килограмм печенья:");
            int cookiesweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько килограмм яблок:");
            int appleweight = Convert.ToInt32(Console.ReadLine());
            int rez = sweet * sweetweight + apple * appleweight + cookies * cookiesweight;
            Console.WriteLine("Стоимость покупки равна {0}", rez);


            Console.ReadKey();
        }
    }
}
