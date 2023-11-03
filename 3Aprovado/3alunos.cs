/*
Quero que você entregue uma aplicação que receba a nota de 3 alunos diferentes e diga quais deles foram aprovados e quais não foram.
Claro que terá que coletar o nome deles para poder informar "Fulano foi aprovado, Beltrano foi reprovado e Ciclano foi aprovado"
*/

using Microsoft.VisualBasic;

Console.WriteLine("Digite o nome do primeiro aluno(Só informaremos a nota dos 3 no final)");
string aluno1 = Console.ReadLine();


Console.WriteLine("Informe a primeira nota");
int PrimeiraNotaAluno1 = int.Parse(Console.ReadLine());
Console.WriteLine("informe a segunda nota");
int SegundaNotaAluno1  = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a terceira nota");
int TerceiraNotaAluno1 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o nome do segundo aluno");
string aluno2 = Console.ReadLine();


Console.WriteLine("Informe a primeira nota");
int PrimeiraNotaAluno2 = int.Parse(Console.ReadLine());
Console.WriteLine("informe a segunda nota");
int SegundaNotaAluno2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a terceira nota");
int TerceiraNotaAluno2 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o nome do terceiro aluno");
string aluno3 = Console.ReadLine();


Console.WriteLine("Informe a primeira nota");
int PrimeiraNotaAluno3 = int.Parse(Console.ReadLine());
Console.WriteLine("informe a segunda nota");
int SegundaNotaAluno3 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a terceira nota");
int TerceiraNotaAluno3 = int.Parse(Console.ReadLine());

int mediaAluno1 = (PrimeiraNotaAluno1 + SegundaNotaAluno1 + TerceiraNotaAluno1) / 3;
int mediaAluno2 = (PrimeiraNotaAluno2 + SegundaNotaAluno2 + TerceiraNotaAluno2) / 3;
int mediaAluno3 = (PrimeiraNotaAluno3 + SegundaNotaAluno3 + TerceiraNotaAluno3) / 3;


    string aprovadoReprovado1 = null;
    string aprovadoReprovado2 = null;
    string aprovadoReprovado3 = null;

    if (mediaAluno1 >= 7)
    {
        aprovadoReprovado1 = $"{aluno1} aprovado(a), ";
    }
    else
    {
        aprovadoReprovado1 = $"{aluno1} reprovado(a)";
    }


    if (mediaAluno2 >= 7)
    {
        aprovadoReprovado2 = $"{aluno2} aprovado(a), ";
    }
    else
    {
        aprovadoReprovado2 = $"{aluno2} reprovado(a)";
    }


    if (mediaAluno3 >= 7)
    {
        aprovadoReprovado3 = $"{aluno3} aprovado(a), ";
    }
    else
    {
        aprovadoReprovado3 = $"{aluno3} reprovado(a)";
    }
string resultado = null;
   resultado = aprovadoReprovado1 + aprovadoReprovado2 + aprovadoReprovado3;


Console.WriteLine(resultado);
