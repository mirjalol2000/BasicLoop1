// See https://aka.ms/new-console-template for more information
int sum = 0;

for(int i = 0; i < 1000; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);
