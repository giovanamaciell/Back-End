public class Program
{
    public static void Main()
    {
        //O try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //a execução do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o n° {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O Resultado é: {resultado}");
        }
        //Tratando exeção de overflow (estouro de campo)
        catch (OverFlowException)
        {
            Console.WriteLine($"Este número inteiro é maior que o suportado");
        }
        //Tratando execução com erro de formato
        catch (FormatException)
        {
            Console.WriteLine($"Erro: Digite um número inteiro");
        }
        //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor compreensão do usuário
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro:{ex.Message}");
        }
        //finally é o bloco execução independentemente se ocorrer erro ou não
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}