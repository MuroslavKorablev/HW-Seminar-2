using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Введите число трехзначное числое: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number < 1000) {
                int secondNumber = (number / 10) % 10;
                System.Console.WriteLine(secondNumber);
                break;
            }
            else {
                Console.WriteLine("Ошибка");
                continue; // возвращаемся к началу цикла
            }
        }
    }
}

