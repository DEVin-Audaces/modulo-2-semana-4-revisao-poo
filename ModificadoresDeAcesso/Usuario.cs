using System;

namespace Revisao.ModificadoresDeAcesso
{
    public class Usuario : Auditoria
    {
        public int Id { get; }
        public string Nome { get; }
        public DateTime DataNascimento { get;}

        public Usuario(DateTime dataNascimento, string nome, int id)
        {
            DataNascimento = dataNascimento;
            Nome = nome;
            Id = id;

            // Exemplo de modificador de acesso "protected"
            // Apesar das propriedades abaixo pertencerem à classe Auditoria
            // É possível acessá-las através da classe Usuario
            // Pois Usuario herda de Auditoria
            DataInclusao = new DateTime();
            UsuarioInclusaoId = new Random().Next();
        }

        public DateTime ObterDataDeInclusao()
        {
            return DataInclusao;
        }
    }
}