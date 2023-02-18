
int[] arr = new int[10];

for (int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write("Enter " + (i+1) + " Numbers : ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = arr.Length - 1; i >=0; i--)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

//int max = arr[0];
//for (int i = 1;i < arr.Length; i++)
//{
//    if (arr[i] > max)
//        max = arr[i];
//}
//Console.WriteLine("Max Number : " + max);

Console.WriteLine("Max Number : " + arr.Max());


//Console.Write("Enter Number # 1 : ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter Number # 2 : ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
