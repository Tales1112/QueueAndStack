using System.Collections.Generic;
using System;
namespace QueueAndStack
{
    public class HistoricoOperacoes
    {
        private Stack<string> _historico;
        public string NomeUsuario { get; private set; }
        public HistoricoOperacoes(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;
            _historico = new Stack<string>();
        }

        public void Adicionar(string nome)
        {
            _historico.Push(nome);
        }

        public void Desfazer()
        {
            Console.WriteLine($"Ultima operacao desfeita.");

            _historico.Pop();
        }

        public string RetornarUltimaOperacao()
        {
            var ultimaOperacao = _historico.Peek();

            return ultimaOperacao;
        }
    }
}
