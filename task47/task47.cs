// Задача 47. Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
// m = 3, n = 4.    0,5 7 -2 -0,2    1 -3,3 8 -9,9    8 7,8 -7,1 9

Console.WriteLine("введите размер массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,]array2d = new int[m,n];
string [] array = new string [n];
Console.WriteLine("введите элементы массива строкой через запятую.");
for(int i = 0; i<m; i++)
{
    string text = Console.ReadLine();
    string[] array[m,n] = new.Split(",");
    for(int j=0; j<n; j++)
    {
            array2d[i,j] = Convert.ToInt32(array[j]);
            Console.Write(array2d[i,j]);
    }
    Console.WriteLine();
}



