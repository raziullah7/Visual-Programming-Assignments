
// creating jagged array
int[][,] arr1 = new int[3][,];

// assigning reference array at each index 0
arr1[0] = new int[2, 2]
{
    { 6, 7 }, { 8, 9 }
};

// assigning reference array at each index 1
arr1[1] = new int[4, 4]
{
    { 1, 2, 3, 4 }, { 11, 12, 13, 14 },
    { 21, 22, 23, 24 }, { 31, 32, 33, 34 }
};

// assigning reference array at each index 1
arr1[2] = new int[1, 1]
{
    { 619 }
};

for (int i = 0; i < arr1.GetLength(0); i++)
{
    int separator = 0;
    Console.WriteLine($" 2D Array at arr[{i}] : ");
    foreach (int item in arr1[i])
    {
        if (separator == arr1[i].GetLength(0)) 
        {
            Console.WriteLine();
            separator = 0;
        }
        Console.Write(" " + item);
        separator++;
    }
    Console.WriteLine();
}