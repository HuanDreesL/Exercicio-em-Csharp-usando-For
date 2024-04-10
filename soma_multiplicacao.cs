//Faça a multiplicação apenas por meio de somas.

Console.WriteLine("Insira o numero que deseja multiplicar: ");
int multiplicar = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o numero que vai multiplicando: ");
int multiplicando = int.Parse(Console.ReadLine());

int resultado = 0;

for (int i = 0; i < multiplicando; i++)
{
    resultado += multiplicar;
}
Console.WriteLine($"Multiplicação de {multiplicar} é {resultado}");
