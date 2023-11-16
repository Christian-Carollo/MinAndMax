Random random = new Random();

List<int> numeriCasuali = new List<int>();

for(int i = 0; i < 1000; i++)
{
    int numeroCasuale = random.Next();

    numeriCasuali.Add(numeroCasuale);
}

foreach (int numeroCasuale in numeriCasuali)
{
    Console.WriteLine(numeroCasuale + "\n");
 
}


int numeroMinimo = numeriCasuali.Min();
int numeroMassimo = numeriCasuali.Max();

Console.WriteLine($"Numero Minimo/Casuale {numeroMinimo}:\n");
Console.WriteLine($"Numero Massimo/Casuale {numeroMassimo}:\n");