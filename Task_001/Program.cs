
void Task1()

{

Console.WriteLine("Введите первое число");
int number_f = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number_s = Convert.ToInt32(Console.ReadLine());

if(number_f > number_s)
{
    Console.WriteLine("Первое число больше второго");
    Console.WriteLine("Первое число:" + number_f);
    Console.WriteLine("Второе число:" + number_s);
}
else if(number_s > number_f)
{
    Console.WriteLine("Второе число больше первого");
    Console.WriteLine("Первое число:" + number_f);
    Console.WriteLine("Второе число:" + number_s);
}
else
{
    Console.WriteLine("Оба числа равны");
    Console.WriteLine("Первое число:" + number_f);
    Console.WriteLine("Второе число:" + number_s);
}


}


