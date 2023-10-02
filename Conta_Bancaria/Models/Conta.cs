namespace Model
{

    public class ContaCorrente
    {
        private string titular { get; set; }
        private decimal saldo { get; set; }

        public ContaCorrente(string titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }

        public void Consultar()
        {
            Console.WriteLine($"Seu saldo é de {saldo}");
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Seu depósito é de {saldo}");
            }
        }
        public void sacar(decimal valor)
        {
            
            saldo -= valor;
            Console.WriteLine($"Seu saque é de {saldo}");
        }

    }
}