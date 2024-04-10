//Faça um programa, que solicite a quantidade de
//alunos de uma turma, solicite a nota de cada aluno
//e ao final mostre a média da turma

/*
double soma = 0;
double mediaTurma = 0;
Console.WriteLine("Insira a quantidade de alunos: ");
int quant = int.Parse(Console.ReadLine());

for (int i = 1; i <= quant; i++)
{
    Console.WriteLine($"Insira a a média do {i}° Aluno: ");
    double media = double.Parse(Console.ReadLine());
    soma = soma + media;
    mediaTurma = soma / quant; 
}
Console.WriteLine($"A média da turma é {mediaTurma}");
*/

//Faça um ajuste no programa para solicitar a
//quantidade de turmas da escola e ao final
//mostre a média da escola.

/*
Console.WriteLine("Insira a quantidade de Turmas: ");
int quantTurma = int.Parse(Console.ReadLine());
double mediaEscola = 0;
double somaMedia = 0;

for (int j = 1; j <= quantTurma; j++)
{
    double soma = 0;
    double mediaTurma = 0;
    Console.WriteLine("Insira a quantidade de alunos: ");
    int quant = int.Parse(Console.ReadLine());

    for (int i = 1; i <= quant; i++)
    {
        Console.WriteLine($"Insira a a média do {i}° Aluno: ");
        double media = double.Parse(Console.ReadLine());
        soma = soma + media;
        mediaTurma = soma / quant;
    }
    Console.WriteLine($"A média da turma é {mediaTurma}");
    somaMedia = somaMedia + mediaTurma;
    mediaEscola = somaMedia / quantTurma;


}
Console.WriteLine($"A média da escola é {mediaEscola}");
*/
