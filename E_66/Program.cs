int n, m, s=0;
Console.Write("Введи значение n ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение m ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);