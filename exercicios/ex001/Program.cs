﻿//Exercício 001 Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string

//Receber a nota 1, converter e armazenar em uma variável int

//Receber a nota 2, converter e armazenar em uma variável int

//Receber a nota 3, converter e armazenar em uma variável int

//Declarar uma variável do tipo int, para receber a média das notas
//(nota1 + nota2 + nota3) / 3

//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7

Console.WriteLine($"Digite o nome do aluno");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Digite a nota 1");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3");
int nota3 = int.Parse(Console.ReadLine());

int soma = nota1 + nota2 + nota3;
int divisao = soma / 3;


Console.WriteLine($"soma: {soma}");
Console.WriteLine($"divisão: {divisao}");

if (divisao >= 7)
{
    Console.WriteLine($"O aluno {nomeAluno} tirou nota {divisao}, APROVADO");
}
else
{
    Console.WriteLine($"O aluno {nomeAluno} tirou nota {divisao}, REPROVADO");
}
