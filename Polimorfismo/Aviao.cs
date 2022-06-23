using System;

namespace Revisao.Polimorfismo
{
    public class Aviao : Veiculo
    {
        public Aviao(string tipo) : base(tipo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Decolando o Avião...");
        }

        public override void Frear()
        {
            Console.WriteLine("Baixando os trens de pouso");
        }
    }
}