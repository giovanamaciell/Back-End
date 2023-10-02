using Model;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome");
        ContaCorrente pessoa1 = new ContaCorrente(Console.ReadLine());

        string opcao = "";
        do
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Bem-vindo ao BANK");
            Console.WriteLine("$$$$$$$$$$$$$$$$$");
           // Console.Clear();

            Console.WriteLine("############ MENU ############");
            Console.WriteLine("1- Para consultar saldo");
            Console.WriteLine("2- Para depositar");
            Console.WriteLine("3- Para sacar");
            Console.WriteLine("0- Para sair");
            opcao = Console.ReadLine();

            //Console.Clear();



            switch (opcao)
            {
                case "1":
                    pessoa1.Consultar();
                    break;
                case "2":
                    decimal valorDep = decimal.Parse(Console.ReadLine());
                    pessoa1.Depositar(valorDep);
                    break;
                case "3":
                    decimal valorSac = decimal.Parse(Console.ReadLine());
                    pessoa1.sacar(valorSac);
                    break;
                case "0":
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
        } while (opcao != "0");
    }
}