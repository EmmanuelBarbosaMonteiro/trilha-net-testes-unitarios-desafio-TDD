using System;
using System.Collections.Generic;

namespace NewTalents
{
    public class Calculadora
    {
        private readonly List<string> _historico;
        private readonly string _data;

        public Calculadora(string data)
        {
            _historico = new List<string>();
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            AdicionarHistorico($"{val1} + {val2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            AdicionarHistorico($"{val1} - {val2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            AdicionarHistorico($"{val1} * {val2} = {resultado}");
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            AdicionarHistorico($"{val1} / {val2} = {resultado}");
            return resultado;
        }

        private void AdicionarHistorico(string operacao)
        {
            _historico.Add($"{operacao} - {_data}");
        }

        public List<string> Historico()
        {
            return _historico.GetRange(0, Math.Min(_historico.Count, 3));
        }
    }
}