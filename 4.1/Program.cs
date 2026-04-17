Console.Write("Filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

bool numeroMayor = false;
int mayor = 0;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Valor: ");
        matriz[i, j] = int.Parse(Console.ReadLine());

        if (!numeroMayor)
        {
            mayor = matriz[i, j];
            numeroMayor = true;
        }
        else if (matriz[i, j] > mayor)
        {
            mayor = matriz[i, j];
        }
    }
}
Console.WriteLine("Número mayor: " + mayor);