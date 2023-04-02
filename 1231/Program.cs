using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                Console.WriteLine("Число четное");
            }
            else {
                Console.WriteLine("Число нечетное");
                continue; // возвращаемся к началу цикла
            }
        }
    }
}
