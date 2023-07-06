
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


void Task2()

{

Console.WriteLine("Введите первое число");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num_c = Convert.ToInt32(Console.ReadLine());

int max = num_a;
if(num_b > max) 
{
   max = num_b; 
}

if(num_c > max)
{
    max = num_c;
}

Console.WriteLine("Наибольшее число:" + max);


}

void Task3()

{

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("число является четным");
}
else
{
    Console.WriteLine("число является нечетным");
}

}

void Tast4()
{

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до "+ n + ":");
for(int i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


}
