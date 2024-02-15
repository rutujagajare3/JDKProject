// See https://aka.ms/new-console-template for more information
Console.WriteLine("Item");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Jerry\t" + i);
    Console.WriteLine("Tom\t" + i);
}

int[] num = { 10, 90, 40, 35 };
int[] M1 = { 100, 101, 102, 103 };

foreach (int item in num)
{
    Console.WriteLine(item);
}
foreach (int item in M1)
{
    Console.WriteLine(item);
}
