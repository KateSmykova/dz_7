int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];

Console.WriteLine();
for(int i=0; i<matrix.GetLength(0); i++) 
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+"\t");
    } 
    Console.WriteLine();
    
}

Console.WriteLine();
for(int j=0; j<matrix.GetLength(1);j++)
{
    double sum=0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        sum+=matrix[i,j];
    }
    Console.Write($"{sum/matrix.GetLength(0)}/");
}

Console.ReadLine();