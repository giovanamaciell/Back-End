using System.IO;

public class Program
{
    public static void Main()
    {
        LerArquivo();
        ChamarArquivo();
    }

    public static void LerArquivo()
    {
        try
        {
            string caminhoArquivo = "Arquivo/arquivo.txt"

            //Verificar se o arquivo existe
            if (File.Exists("Arquivo/arquivo.txt") == False)
            {
                //Criando meu arquivo.txt, este comando é executado quando
                //a verificação no if é falsa ou seja o arquivo não existe
                File.Create("Arquivo/arquivo.txt")
}
            //Instanciando um objeto da Classe StreamWriter para ler o arquivo
            using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
            {
                string linha;
                //fazendo o while para ler linha por linha que contém no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo {erro.Message}");
        }
    }
    public static void ChamarArquivo()
    {
        try
        {

            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine($"Digite algo");
                arquivo.WriteLine(Console.ReadLine());
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}