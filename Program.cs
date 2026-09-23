//Funcion de impresion de notas
using System.Data;
using System.Xml.Linq;

static void ImprimirNotas(int[] notasx)
{
    for(int i = 0; i < notasx.Length; i++)
    {
        Console.WriteLine($"nota {i+1}: {notasx[i]}");
    }
}

//Funcion de promedio de notas
static double PromedioNotas(int[] notasx)
{
    int suma = 0;
    for(int i = 0; i < notasx.Length; i++)
    {
        suma += notasx[i];
    }
    return (double)suma / notasx.Length;
}

int[] notas = {15,18,12,17,20};

//imprimir el arreglo de notas
ImprimirNotas(notas);

//promedio de las notas
double promedio = PromedioNotas(notas);
Console.WriteLine($"El promedio de las notas es: {promedio:F2}");



//Imprimir minimo y maximo de las notas
int min = notas[0];
int max = notas[0];
for(int i = 1; i < notas.Length; i++)
{
    if(notas[i] < min)
    {
        min = notas[i];
    }
    if(notas[i] > max)
    {
        max = notas[i];
    }
}
Console.WriteLine($"La nota mínima es: {min}");
Console.WriteLine($"La nota máxima es: {max}");


