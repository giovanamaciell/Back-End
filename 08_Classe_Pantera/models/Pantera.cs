namespace Model
{
    public class Pantera
    {
        public string tamanho { get; set; }
        public string peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Apresentar()
        { Console.WriteLine($"Essa pantera da espécie {especie}e cor {cor} mede {tamanho}, se alimenta de {alimentacao} e pesa {peso}"); }

        public void Correr()
        {
            Console.WriteLine($"Uma pantera pode atingir a velocidade de até 114 km por hora.");
        }

        public void Cacar()
        {
            Console.WriteLine($"Essa pantera gosta de se alimentar de {alimentacao}");
        }

        public void Reproduzir()
        {
            Console.WriteLine($"A época de acasalamento começa em fevereiro e vai até março, num período de gestação de 90 dias e ninhada de 3 a 5 filhotes.");
        }
    }
}