using System;

namespace Revisao.Polimorfismo
{
    public static class TestePolimorfismo
    {
        public static void Iniciar()
        {
            var veiculos = new Veiculo[2];

            // Carro é um veículo
            veiculos[0] = new Carro("Uno");
            // Avião é um veículo
            veiculos[1] = new Aviao("Boeing");

            veiculos[0].Frear();
            veiculos[1].Frear();
        }
    }
}