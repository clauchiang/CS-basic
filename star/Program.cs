int i;
int j;
int size =6;

Console.WriteLine("直角三角形");
for(i=1;i<=size;i++)
{
    for(j=1;j<=i;j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("倒直角三角形");
for(i=0;i<size;i++)
{
    for(j=size;j>i;j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("正三角形");
int k;
for (i = 1; i <= size; i++)
{
    for(k=size;k>i;k--)
    {
        Console.Write(" ");
    }
    for(j=1;j<=i;j++)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();
}