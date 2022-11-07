// Задача 23 Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125

void Cube(int n)
{
    if (n > 0)
    {
         int index = 1;
         while (index <= n)
        {
            Console.WriteLine($"{index} {index*index*index}");
            index++;
        }
    }
    else Console.WriteLine("неверное число");
}

Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);