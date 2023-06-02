 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 
 using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Введите число трехзначное числое: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number < 1000) {
                int thirdNumber = number % 10;  
                System.Console.WriteLine(thirdNumber);
                break;
            }
            else {
                Console.WriteLine("Ошибка");
                continue; // возвращаемся к началу цикла
            }
        }
    }
}
