// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = 5;
int number = 1;
int result;

while (number <= a)
{
    result = (number * number * number);
    number++;
    Console.WriteLine(result);
}
