using System;

namespace Revisao.Polimorfismo
{
    public class Carro : Veiculo
    {
        public string Marca { get; set; }
        public Carro(string tipo) : base(tipo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o Carro...");
        }
    }
}