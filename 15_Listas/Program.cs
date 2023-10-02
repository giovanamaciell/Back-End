using System.Collections.Generic;
using Sesi.models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos á lista
        listaNumeros.Add(10); // posição [0]
        listaNumeros.Add(20); // posição [1]
        listaNumeros.Add(45); // posição [2]

        //Acessando os dados da lista pelo índice 
        Console.WriteLine(listaNumeros[0]);

        //Contagem de elementos
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

        //*******************************LISTA NOMES*******************************//
        Console.WriteLine($"#################################");

        List<string> listaNomes = new List<string>();

        //Adicionando elementos á lista
        listaNomes.Add("Maia"); // posição [0]
        listaNomes.Add("Giovana"); // posição [1]
        listaNomes.Add("Julia"); // posição [2]

        //Acessando os dados da lista pelo índice 
        Console.WriteLine(listaNomes[0]);

        //Contagem de elementos
        Console.WriteLine($" Neste momento temos {listaNomes.Count} nomes");

        //Criando uma lista de números já atribuindo valores
        List<int> numeros = new List<int>(1, 2, 5, 6, 8, 9);
        Console.WriteLine($"Quantidade de elementos na lista de números {numeros.Count}");
        numeros.Remove(2); //Remover o elemento 2
        numeros.RemoveAt(1); //Remover o elemento no índice 1
        numeros.RemoveRange(2, 2); //Remover 2 elementos a partir do índice 2

        //Substituindo informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        foreach (string nome in listaNomes)
        {
            Console.WriteLine(nome);
        }

        //Criando uma lista com objetos da Classe Alunos
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add("Bob", 16);
        listaAlunos.Add("Patrícia", 17);

        //Exibindo lista de alunos
        Console.WriteLine($"Lista de Alunos:");

        //Criando uma nova lista, ordenando por nome
        ///LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                       where aluno.idade == 17
                       orderby aluno.nome
                       select aluno.nome;

        foreach (var aluno in ordenação)
        {
            Console.WriteLine(aluno);
        }

        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.nome);

        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }
}