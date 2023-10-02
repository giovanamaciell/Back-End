using Model;
class Program
{
    public static void Main()
    {
        var pantera1 = new Pantera();

        pantera1.tamanho = "3,1 metros";
        pantera1.peso = "170 kg";
        pantera1.cor = "Laranja";
        pantera1.especie = "Tigre-de-bengala ";
        pantera1.alimentacao = "animais pequenos";

        pantera1.Apresentar();
        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
    }
}