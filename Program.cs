//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[,] resultArray = ResultArray(array);
// PrintMyArray(resultArray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine($"Строка с наименьшей суммой - {minSumRow(array)} - сумма состовляет {minSum(array)}");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите количество строк 1 матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);
if(columns != rows2){
    Console.WriteLine("Такие матрицы умножать нельзя!");
}
int[,] array = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(GetMultiMatrix(array,array2));



//------------методы-----------------
int[,] GetArray(int m, int n, int minValue, int maxValue){ // Заполнения массива
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){ //Печатает двумерный массив
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ResultArray(int[,] MyArray){ // Ищет наибольшее число в строчке массива
    for(int i = 0; i < MyArray.GetLength(0); i++){
        for(int j = 0; j < MyArray.GetLength(1); j++){
            for(int k = 0; k < MyArray.GetLength(1) - 1; k++){
                if(MyArray[i,k] < MyArray[i,k+1]){
                int temp = MyArray[i,k];
                MyArray[i,k] = MyArray[i,k+1];
                MyArray[i,k+1] = temp;
                }
            }
        }
    }
    return MyArray;
}
void PrintMyArray(int[,] MyArray){ //Печатает результат работы с массивом
    for(int i = 0; i < MyArray.GetLength(0); i++){
        for(int j = 0; j < MyArray.GetLength(1); j++){
            Console.Write($"{MyArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int minSumRow(int[,] array){ // находим наименьшую сумму строки массива выводим строку
    int row = 0;
    int minSum = 0;
    for(int i = 0; i < array.GetLength(1); i++ ){
        minSum += array[0,i];
    }
    for (int i = 1; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }
        if (minSum > sum){
            minSum = sum;
            row = i;
        }
    }
    return row;
}
int minSum(int[,] array){ //находим наименьшую сумму строки массива выводим сумму
    int minSum = 0;
    for(int i = 0; i < array.GetLength(1); i++ ){
        minSum += array[0,i];
    }
    for (int i = 1; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }
        if (minSum > sum){
            minSum = sum;
        }
    }
    return minSum;
}

int [,] GetMultiMatrix(int[,] array, int[,] array2){ //произведение дву матриц
    int[,] arrayResult = new int [array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(1); k++){
                arrayResult[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return arrayResult;
}



