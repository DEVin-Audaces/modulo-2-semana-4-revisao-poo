using System;

namespace Revisao.ModificadoresDeAcesso
{
    public class Auditoria : Log
    {
        public int UsuarioInclusaoId { get; set; }
        protected DateTime DataInclusao { get; set; }

        // Permite a sobreescrita
        // Quem herdar de Auditoria terá acesso ao método ImprimirLog()
        // Porém, como o método está definido como virtual
        // A classe filha tem a possibilidade de sobreescrever este método
        public virtual void ImprimirLog()
        {
            Console.WriteLine($"Registro inserido pelo usuário {UsuarioInclusaoId} na data {DataInclusao}");
        }


        // Método implementado através de um método abstrato definido na classe herdade Log
        // Este método fica disponível para todos as classes que herdarem de Auditoria
        // Classe herda de Auditoria e Auditoria herda de Log
        public override void ImprimirLogAvancado()
        {
            Console.WriteLine("LOG AVANÇADO");
        }

    }
}