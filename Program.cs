//Funcion de impresion de notas
using System.Data;

static void ImprimirNotas(int[] notasx)
{
    for(int i = 0; i < notasx.Length; i++)
    {
        Console.WriteLine($"nota {i+1}: {notasx[i]}");
    }
}

int[] notas = {15,18,12,17,20};

//imprimir el arreglo de notas
ImprimirNotas(notas);

//promedio de las notas
int suma = 0;
for(int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}
Console.WriteLine($"El promedio de las notas es: {(double)suma / notas.Length:F2}");




