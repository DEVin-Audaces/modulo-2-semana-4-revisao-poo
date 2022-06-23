using System;

namespace Revisao.ClassesAbstrataEInterface
{
    public class TesteInterface
    {
        public static void Iniciar()
        {
            var carro = new Carro();
            var moto = new Moto();
            var caminhao = new Caminhao();

            ImprimirModeloAutomovel(carro);
            ImprimirModeloAutomovel(moto);
            ImprimirModeloAutomovel(caminhao);

        }
        
        public static void ImprimirModeloAutomovel(IAutomovel interfaceAutomovel)
        {
            Console.WriteLine("automovel:" + interfaceAutomovel.Modelo);
        }

        public void ImprimirModeloCarro(Carro carro)
        {
            Console.WriteLine("automovel:" +carro.Modelo);
        }

        public void ImprimirModeloMoto(Moto moto)
        {
            Console.WriteLine("automovel:" + moto.Modelo);
        }

        public void ImprimirModeloCaminhao(Caminhao caminhao)
        {
            Console.WriteLine("automovel:" + caminhao.Modelo);
        }
    }
}