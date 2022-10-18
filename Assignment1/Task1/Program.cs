Console.Write("Input the size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[size, size];
int rowSum = 0, colSum = 0, diagonalSum = 0, MaxSum = 0;

for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
        arr[i, j] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < size; i++)
{
    diagonalSum += arr[i, i];
    for (int j = 0; j < size; j++)
    {
        colSum += arr[j, i];
        rowSum += arr[i, j];
    }
    MaxSum = new[] { diagonalSum, rowSum, colSum }.Max();
    rowSum = 0;
    colSum = 0;
}

Console.WriteLine("MaxSum is:  " + MaxSum);