class Program
{
    public static void Main()
    {
        ListaDoChurrasco();
    }

    public static void ListaDoChurrasco()
    {
        string[] lista = new string[6];
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Digite o produto que vamos comprar");
            string produto = Console.ReadLine();
            lista[i] = produto;
        }

        Array.Sort(lista);

        foreach (string item in lista)
            Console.WriteLine(item);
    }


    //Sonhos de Consumo
    public static void listaSonho()
    {
        string[] sonhos = new string[3];
        decimal[] valor = new decimal[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Informe o seu {i}º sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valores = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores)
        {
            total = total + val;
        }
        Console.WriteLine($"Seus sonhos custarão aprox. R${total}");
    }
}