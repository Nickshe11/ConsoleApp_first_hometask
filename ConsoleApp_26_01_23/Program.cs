using System.Globalization;
using static System.Console;

Console.WriteLine("Введите номер задачи");
int choise = Convert.ToInt32(Console.ReadLine());

switch (choise)
{
    case 1:
        {
            Console.WriteLine("Введите число от 1 до 100");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            else
            {
                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (number % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else Console.WriteLine($"Введенное число: {number}");
                    }
                }
            }
        }
        break;
    case 2:
        {
            Console.WriteLine("Введите значение: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент: ");
            int percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(percent + " процентов от " + number + " = " + number * percent / 100);
        }
        break;
    case 3:
        {
            //Console.WriteLine("Введите значение: ");
            //int number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение: ");
            //int number_2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение: ");
            //int number_3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение: ");
            //int number_4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Было введено число " + number_1 +  number_2 +number_3+number_4);
            string number = "";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите {i + 1} значение: ");
                number += Console.ReadLine();
            }
            Console.WriteLine(number);
        }
        break;
    case 4:
        {
            Console.WriteLine("Введите шестизначное число: ");
            string number = Console.ReadLine();
            if (number.Length < 6 || number.Length > 6)
            { Console.WriteLine("Ошибка ввода"); break; }
            Console.WriteLine("Введите индекс первого заменяемого числа: ");
            int change_1 = (Convert.ToInt32(Console.ReadLine()) - 1);
            Console.WriteLine("Введите индекс второго заменяемого числа: ");
            int change_2 = (Convert.ToInt32(Console.ReadLine()) - 1);
            if (change_1 < 1 || change_1 > 6 || change_2 < 1 || change_2 > 6)
            { Console.WriteLine("Ошибка ввода"); break; }
            char[] num_char = number.ToCharArray();
            char buffer = num_char[change_2];
            num_char[change_2] = num_char[change_1];
            num_char[change_1] = buffer;
            Console.WriteLine($"Число после смены цифр: {String.Concat(num_char)}");

        }
        break;
    case 5:
        {
            DateTime date;
            string buffer;
            int temp;
            do
            {
                Console.WriteLine("Введите дату в формате YYYY.MM.DD: ");
                buffer = Console.ReadLine();
            } while (!DateTime.TryParseExact(buffer, "yyyy.MM.dd", null, DateTimeStyles.None, out date));
            temp = Convert.ToInt32(date.ToString("MM"));
            if (temp > 2 && temp < 6) buffer = "Spring";
            else if (temp < 9) buffer = "Summer";
            else if (temp < 12) buffer = "Autumn";
            else buffer = "Winter"; ;
            Console.WriteLine(buffer + date.DayOfWeek);
        }
        break;
    case 6:
        {
            Console.WriteLine("Введите значение температуры");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите вид преобразования введенного значения, где: \n 1 - из градусов по Цельсию в градусы по Фаренгейту \n 2 - из градусов по Фаренгейту в градусы по Цельсию");
            byte choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine($"Температура по цельсию = {temp} градусов, температура по Фаренгейту = {temp * 1.8 + 32}"); break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Температура по Фаренгейту = {temp} градусов, температура по Цельсию = {(temp - 32) / 1.8}"); break;
                    }
                default: Console.WriteLine("Ошибка ввода"); break;
            }
            break;
        }
    case 7:
        {

            Console.WriteLine("Введите первое число диапазона: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число диапазона: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            if (num_1>num_2)
            {
                int buffer = num_2;
                num_2 = num_1;
                num_1 = buffer;
            }
            for(int i=num_1;i<=num_2;i++)
            {
                if (i % 2 == 0) Console.Write($"{i} ");
            }
        }
        break;
    default: Console.WriteLine("Задачи кончились");break;

}