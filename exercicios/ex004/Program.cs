class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número");
        int dobro = int.Parse(Console.ReadLine());
        int valor = Dobro(dobro);
        Console.WriteLine($"Dobro{valor}");
        int valorDigitado = int.Parse(Console.ReadLine());
        int metade = Metade(valorDigitado);
        Console.WriteLine($"Metade{metade}");

        Console.WriteLine("Digite um número para calcular a tabuada");
        CarregarTabuada(int.Parse(Console.ReadLine()));
        Soma();
    }

    public static int Dobro(int num)
    {
        int resultado = (num * 2);
        return resultado;
    }
    public static int Metade(int num)
    {
        int resultado = (num / 2);
        return resultado;
    }

    public static void CarregarTabuada(int n)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador * n);
            contador++;
        }
    }

    public static void Soma()
    {
        int soma = 0;
        int menor = 1000;
        int maior = 0;
        int num = 0;
        do
        {
            num = int.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;
            if (num < menor)
                menor = num;

            soma = soma + num;
        } while (num > 0);

        Console.WriteLine($"O número maior é {maior} o menor é {menor} e soma é {soma}");
    }
}