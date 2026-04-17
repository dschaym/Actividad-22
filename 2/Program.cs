Console.Write("Filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Valor: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Buscar fila: ");
int fila = int.Parse(Console.ReadLine());

for (int j = 0; j < columnas; j++)
{
    Console.Write(matriz[fila, j] + " ");
}
