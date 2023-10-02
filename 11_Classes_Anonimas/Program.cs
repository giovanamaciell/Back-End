public class Program
{
    public static void Main()
    {
        //Criando classe anônima (classe sem definição inicial)
        var pessoa1 = new
        {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new
        {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa 1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa 2 é {pessoa2.nome} e tem {pessoa2.email} anos");

        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de carro

        var carro1 = new
        {
            marca = "Toyota",
            modelo = "Corolla",
            cor = "Cinza",
            ano = "2010"
        };

        var carro2 = new
        {
            marca = "Volkswagen",
            modelo = "Gol",
            cor = "Cinza",
            ano = "2020"
        };
        Console.WriteLine($"O carro 1 é da marca {carro1.marca}, modelo {carro1.modelo} e cor {carro1.cor} do ano de {carro1.ano}");
        Console.WriteLine($"O carro 2 é da marca {carro2.marca}, modelo {carro2.modelo} e cor {carro2.cor} do ano de {carro2.ano}");
    }
}