
Console.Write("Filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Valor [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Número a buscar: ");
int buscar = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (matriz[i, j] == buscar)
        {
            Console.WriteLine($"Encontrado en fila {i}, columna {j}");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("Número no encontrado");
}