using System;

namespace Revisao.ModificadoresDeAcesso
{
    public class Pessoa : Auditoria
    {
        public Pessoa()
        {
            DataInclusao = new DateTime();
            UsuarioInclusaoId = new Random().Next();
        }

        // Método que sobreescreve o método da classe  Auditoria
        public override void ImprimirLog()
        {
            Console.WriteLine($"CLASSE PESSOA: Registro inserido pelo usuário {UsuarioInclusaoId} na data {DataInclusao}");
        }
    }
}