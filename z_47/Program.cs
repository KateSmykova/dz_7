int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double[,] matrix = new double [rows, columns];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-10,11);
        Console.Write(matrix[i,j]+"\t");
    } 
    Console.WriteLine();
}