﻿//Classe pai que será herdada pelo filho - SuperClasse
abstract class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

//Classe filha que herdará da classe animal
//Receberá todos os atributos e métodos da SuperClasse

class Cachorro : Animal
{

    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }

}

class Gato : Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("O gato está miando");
    }
}

class Program
{
    public static void Main()
    {
        //Não é permitido instanciar um objeto de uma classe abstrata
        //Animal animalGenerico = new Animal();
        //animalGenerico.EmitirSom()

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}


