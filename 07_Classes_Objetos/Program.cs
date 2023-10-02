//Sempre que formos utilizar bibliotecas ou classes já criadas
//importamos ela com o using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variável aluno1 e instanciando da classa Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atirbuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Giovana";
        aluno1.idade = 17;
        aluno1.turma = "2°EM";
        //Chamando ométodo da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        //Chamando o método da classe Aluno
        aluno1.Apresentar();

        var aluno2 = new Aluno();
        aluno2.nome = "Larissa";
        aluno2.idade = 18;
        aluno2.turma = "3°EM";
        aluno2.Apresentar();


    }
}