using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um método construtor
        /*var pessoa1 = new Pessoa();
          pessoa1.nome = "Giovana";
          pessoa1.idade = 17;
          pessoa1.Cantar();

          //Alternativa para criação de um objeto sem construtor
          Pessoa pessoa2 = new Pessoa
          {
              nome = "Ricardo",
              idade = 22
          };
          pessoa2.Cantar();
          */

        Pessoa pessoa1 = new Pessoa("Giovana", 17, "venanciogiovana@gmail.com");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Julia", 16, "juliasilvaoliv@gmail.com");
        pessoa2.Cantar();
        pessoa2.Informacoes();

        Pessoa pessoa3 = new Pessoa("Clara", 17, "diassangaliclara@gmail.com");
        pessoa3.Cantar();
        pessoa3.Informacoes();
    }
}