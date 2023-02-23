// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = (3);
int index = 0;
int result = (index * index * index);

while (result <= a)
{
    index++;
}


Console.WriteLine(result);
