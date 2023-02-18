
int[,] arr = new int[3,4];

Console.WriteLine("Enter 20 Numbers : in 2D Array");

for (int i = 0;i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"Value at arr[{i}][{j}] : {arr[i, j]}");
    }
}