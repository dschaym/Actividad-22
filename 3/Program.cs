Console.Write("Filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];
int suma = 0;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Valor [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
        suma += matriz[i, j];
    }
}

Console.WriteLine("Suma total: " + suma);