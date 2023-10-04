int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
int[] results = new int[(2 * size) + 2];
bool isMagicSquare = true;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < matrix.GetLength(1); i++)
{
    int result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }

    results[i + size] = result;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result += matrix[i, j];
    }

    results[i] = result;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    results[results.Length - 2] += matrix[i, i];
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    results[results.Length - 1] += matrix[i, (matrix.GetLength(1) - 1) - i];
}


for (int i = 1; i < results.Length; i++)
{
    if (results[i - 1] != results[i])
    {
        isMagicSquare = false;
    }
}

for (int i = 0; i < results.Length; i++)
{
    Console.Write(results[i] + ",");
}

if (isMagicSquare)
{
    Console.Write("Y");
}
else
{
    Console.Write("N");
}