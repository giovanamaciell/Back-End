Console.WriteLine("Digite o valor de x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restDiv2 = x % 2; //Calculando o resto da divisão de x / 2


//Console para exibir na tela
//Soma: 15
Console.WriteLine($"soma: {soma}");
Console.WriteLine($" subtração: {subtracao}");
Console.WriteLine($"multiplicação: {multiplicacao}");
Console.WriteLine($"divisão: {divisao}");
Console.WriteLine($"resto: {resto}");

if (restDiv2 == 0)
{
    Console.WriteLine($"O número {x} é par");
}
else
{
    Console.WriteLine($"O número {x} é ímpar");
}


int restDiv3 = y % 2; //Calculando o resto da divisão de y / 2

if (restDiv3 == 1)
{
    Console.WriteLine($"O número {y} é ímpar");
}
else
{
    Console.WriteLine($"O número {y} é par");
}


//Operador ternário
// condição ? se verdade, senão
string resultado = (restDiv3 == 0) ? $"O número {y} é par" : $"O número {y} é ímpar";
Console.WriteLine(resultado)

int diaSemana = 3:
//Aprendendo o Switch Case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo!")
        break;
    case 2:
        Console.WriteLine("Hoje é segunda!")
        break;
    case 3:
        Console.WriteLine("Hoje é terça!")
        break;
    case 4:
        Console.WriteLine("Hoje é quarta!")
        break;
    case 5:
        Console.WriteLine("Hoje é quinta!")
        break;
    case 6:
        Console.WriteLine("Hoje é sexta!")
        break;
    case 7:
        Console.WriteLine("Hoje é sábado!")
        break;
    default:
        Console.WriteLine("Dia inválido");
}