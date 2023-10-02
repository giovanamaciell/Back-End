Console.WriteLine("Digite o último número da placa");
string placa = Console.ReadLine();

placa = placa.Substring(placa.Length - 1, 1);

if (placa == "1" || placa == "2")
{
    Console.WriteLine($"Essa placa {placa} é permitida a andar somente em dias de segunda");
}
else if (placa == "3" || placa == "4")
{
    Console.WriteLine($"Essa placa {placa} é permitida a andar somente em dias de terça");
}
else if (placa == "5" || placa == "6")
{
    Console.WriteLine($"Essa placa {placa} é permitida a andar somente em dias de quarta");
}
else if (placa == "7" || placa == "8")
{
    Console.WriteLine($"Essa placa {placa} é permitida a andar somente em dias de quinta");
}
else if (placa == "9" || placa == "0")
{
    Console.WriteLine($"Essa placa {placa} é permitida a andar somente em dias de sexta");
}
