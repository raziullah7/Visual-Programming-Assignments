
// int[][] arr = new int[2][];
int[][,] arr = new int[2][,];
//int[,][] arr = new int[2,2][];

//arr[0] = new int[3];
//arr[1] = new int[4];

// this does not work
// arr[0] = new int[3][2];


arr[0] = new int[3, 3];
arr[1] = new int[4, 4];


//arr[0,0] = new int[4];
//arr[0,1] = new int[3];
//arr[1,0] = new int[2];
//arr[1,1] = new int[1];


//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        Console.Write($"Enter Value at arr[{i}][{j}] : ");
//        arr[i][j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        Console.WriteLine($"Enter Value at arr[{i}][{j}] : {arr[i][j]}");
//    }
//}

// multi-dimensional arrays in a single dimensional jagged array
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr[i].GetLength(0); j++)
    {
        for (int k = 0; k < arr[i].GetLength(1); k++)
        {
            Console.Write($"Enter Value at arr[{i}][{j}][{k}] : ");
            arr[i][j, k] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr[i][j].)
//}




