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


int minNota = notas[0];
for(int i = 1; i < notas.Length; i++)
{
    if(notas[i] < minNota)
    {
        minNota = notas[i];
    }
}
Console.WriteLine($"La nota minima es: {minNota}");



int MaxNota = notas [0];
for(int i =0; i < notas.Length ; i++)
{
    if(notas[i] > MaxNota)
    {
        MaxNota = notas[i];
    }
}
Console.WriteLine($"La nota maxima es: {MaxNota}");



