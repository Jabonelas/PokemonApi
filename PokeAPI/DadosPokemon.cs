using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;

namespace PokeAPI
{
    internal class DadosPokemon
    {
        public int indice { get; set; }
        public string tipo0 { get; set; }
        public string tipo1 { get; set; }
        public string imagem { get; set; }
        public string nome { get; set; }
        public long altura { get; set; }
        public long peso { get; set; }
        public string categoria { get; set; }
        public long valorHP { get; set; }
        public long valorAtaque { get; set; }
        public long valorDefesa { get; set; }
        public long valorAtaqueEspecial { get; set; }
        public long valorDefesaEspecial { get; set; }
        public long valorVelocidade { get; set; }

        public DadosPokemon(int _indice, string _tipo0, string _tipo1, string _imagem, string _nome, long _altura, long _peso, string _categoria, long _valorHp, long _valorAtaque, long _valorDefesa,
            long _valorAtaqueEspecial, long _valorDefesaEspecial, long _valorVelocidade)
        {
            indice = _indice;
            tipo0 = _tipo0;
            tipo1 = _tipo1;
            imagem = _imagem;
            nome = _nome;
            altura = _altura;
            peso = _peso;
            categoria = _categoria;
            valorHP = _valorHp;
            valorAtaque = _valorAtaque;
            valorDefesa = _valorDefesa;
            valorAtaqueEspecial = _valorAtaqueEspecial;
            valorDefesaEspecial = _valorDefesaEspecial;
            valorVelocidade = _valorVelocidade;
        }
    }
}