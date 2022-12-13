// Задайте двумерный массив (вручную) размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Ведите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
float [,] array2d = new float[m, n];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next(-10,10);
        Console.Write(array2d[i,j]+" ");
    }
Console.WriteLine();
}
