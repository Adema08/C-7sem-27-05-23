// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] Fill(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = Fill(length);
System.Console.WriteLine(string.Join(", ", array));
int[] copy = new int[length];
for(int i = 0; i < length; i++) {
    copy[i] = array[i];
}
System.Console.WriteLine(string.Join(", ", copy));