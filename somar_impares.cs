int soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Insira o {i}°: ");
    int valor = Convert.ToInt32( Console.ReadLine() );
    if ((valor % 2) == 1)
    {
    soma = soma + valor;
    }
