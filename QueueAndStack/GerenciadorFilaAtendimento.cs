using System.Collections.Generic;
using System;

namespace QueueAndStack
{
    public class GerenciadorFilaAtendimento
    {
        private Queue<int> _filaAtendimento;
        private int _proximoNumeroParaGerar = 1;

        public GerenciadorFilaAtendimento()
        {
            _filaAtendimento = new Queue<int>();
        }

        public int GerarSenha()
        {
            _filaAtendimento.Enqueue(_proximoNumeroParaGerar);

            Console.WriteLine("Senha gerada");

            return _proximoNumeroParaGerar++;
        }
        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _filaAtendimento.Dequeue();

            Console.WriteLine($"Proxima senha: {proximoNumeroDaFila}");
        }
        public void ChecarProximo()
        {
            var checarNumeroProximoDaFila = _filaAtendimento.Peek();

            Console.WriteLine($"Proxima senha da fila: {checarNumeroProximoDaFila}");
        }

        public void MostrarFila()
        {
            Console.WriteLine("Senha da fila: ");

            foreach (var senha in _filaAtendimento)
            {
                Console.WriteLine(senha + " ");
            }

            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            _filaAtendimento.Clear();
        }
    }
}
