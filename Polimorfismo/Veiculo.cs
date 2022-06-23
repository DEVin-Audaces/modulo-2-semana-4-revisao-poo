using System;

namespace Revisao.Polimorfismo
{
    public abstract class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipo)
        {
            Tipo = tipo;
        }

        // Métodos do tipo abstract obrigam as classes filhas a implementarem o método
        public abstract void Mover();

        // Métodos do tipo virtual possuem implemtação porém possibilitam a sobrescrita
        public virtual void Frear()
        {
            Console.WriteLine("Frear veículo");
        }

    }
}