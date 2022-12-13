//Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает индекс этого элемента или же указание, что такого элемента нет. 
//Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Ведите число массива n");
int n = Convert.ToInt32(Console.ReadLine());
int m=4,k=4;
int [,] array2d = new int[m, k];
int z=0;
Random random = new Random();
for (int i=0; i<array2d.GetLength(0);i++)
{
    for (int j=0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j]=random.Next(0,10);
        Console.Write(array2d[i,j]+" ");
        if (array2d[i,j]==n)
            Console.Write("Индекс искомого элемента: "+i+","+j+" ");
        else
            z++;
    }
Console.WriteLine();
}
if (z>=m*k)
Console.Write("Такого числа в массиве нет");