//Funcion de impresion de notas
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

static int SumarNotas(int[] notasx)
{
    int suma = 0;
    for(int i = 0; i < notasx.Length; i++)
    {
        suma += notasx[i];
    }
    return suma;
}

int sumaTotal = SumarNotas(notas);
Console.WriteLine($"Suma total: {sumaTotal}");


