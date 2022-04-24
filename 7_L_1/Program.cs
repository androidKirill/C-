// ----------------------------------------------------1_1
// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

string s_a = Console.ReadLine();
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (b == a * a)
{
    Console.WriteLine("Yes");    
}
else
{
    Console.WriteLine("No");
}

// ---------------------------------------------------- 1_2
// Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a == 1)
{
    Console.WriteLine("Monday");
}
if (a == 2)
{
    Console.WriteLine("Tuesday");
}
if (a == 3)
{
    Console.WriteLine("Wednesday");
}
if (a == 4)
{
    Console.WriteLine("Thursday");
}
if (a == 5)
{
    Console.WriteLine("Friday");
}
if (a == 6)
{
    Console.WriteLine("Saturday");
}
if (a == 7)
{
    Console.WriteLine("Sunday");
}

// ---------------------------------------------------- 2_1
// Напишите программу вычисления функции:
//  y = f(x)

string s_x = Console.ReadLine();
int x = int.Parse(s_x);
int y;

y = -2 * (x * x) + 4 * x + 2;
Console.WriteLine(y);


// ---------------------------------------------------- 2_2
// Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int m = -N;

while (m <= N)
{
    Console.Write($"{m} ");
    m += 1;
}


// ---------------------------------------------------- *_1
// *. Напишите программу вычисления модуля числа.

string s_N = Console.ReadLine();
int N = int.Parse(s_N);

if (N < 0)
{
    N = -N;
}

Console.Write(N);

// ---------------------------------------------------- *_2
// **. Напишите программу, которая на вход принимает значение, а
// на выходе показывает обратное значение.

string s_N = Console.ReadLine();
float N = float.Parse(s_N);

Console.Write($"{N} -> {1 / N}");