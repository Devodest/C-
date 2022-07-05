/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */


Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void ProductOfTwoArray(int[,] array, int[,] array2)
{
    int rowMatrixArray = array.GetLength(0);
    int columsMatrixArray = array.GetLength(1);
    int rowMatrixArray2 = array2.GetLength(0);
    int columsMatrixArray2 = array2.GetLength(1);
    int temp = 0;
    int[,] array3 = new int[rowMatrixArray, columsMatrixArray2];
    if (columsMatrixArray != rowMatrixArray2){
        Console.WriteLine("Матрицы не могут быть перемножены");
    }
    else{
        for (int i = 0; i < rowMatrixArray; i++){
            for (int j = 0; j < columsMatrixArray2; j++){
                temp = 0;
                for (int k = 0; k < columsMatrixArray; k++){
                    temp += array[i,k] * array2[k,j];
                }
                array3[i,j] = temp;
                Console.Write(array3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Введите кол-во строк в массиве массиве");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве массиве");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("1 матрица");
int[,] array = new int[rows, colums];
CreateRandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("2 матрица");
int[,] array2 = new int[colums, rows];
CreateRandomArray(array2);
PrintArray(array2);
int[,] array3 = new int[rows, rows];
Console.WriteLine("Результат перемножения матриц");
ProductOfTwoArray(array, array2);