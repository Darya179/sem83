//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк матрицы A: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы A: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы B (равно количеству столбцов матрицы А):  ");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы B: ");
int columns1 = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiArr(int[,] aArr, int[,] bArr)
{
 int[,]  cArr = new int[aArr.GetLength(0), bArr.GetLength(1)];
 for (int i = 0; i < aArr.GetLength(0); i++)
 {
    for (int j = 0; j < aArr.GetLength(1); j++)
    {
        cArr[i, j] = 0;
        for (int l = 0; l < aArr.GetLength(1); l++)
        {
            cArr[i, j]+= aArr[i, l]*bArr[l, j];
            
        }
      
    }
 }
return cArr;

}

int[,] array = GetArray(rows, columns, 1, 10);
Console.WriteLine("А:");
PrintArray(array);
Console.WriteLine(" ");
int[,] array1 = GetArray(rows1, columns1, 1, 10);
Console.WriteLine("В:");
PrintArray(array1);
Console.WriteLine(" ");
Console.WriteLine("C:");

int[,] res = MultiArr(array,array1);
PrintArray(res);

