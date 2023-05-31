// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Binary(int n) {
    if (n == 0) {
        return 0;
    }
    Binary(n / 2);
    Console.Write($"{n % 2}");
    return 0;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{Binary(n)}");
Binary(n);
