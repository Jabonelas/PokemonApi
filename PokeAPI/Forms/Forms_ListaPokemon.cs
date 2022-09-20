using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeAPI.Forms
{
    public partial class Forms_ListaPokemon : DevExpress.XtraEditors.XtraForm
    {
        private string tela = string.Empty;
        private string tipo = string.Empty;
        private Color corFundo = Color.AliceBlue;

        public Forms_ListaPokemon(string _tipo, Color _corFundo, string _tela)
        {
            InitializeComponent();

            tipo = _tipo;
            corFundo = _corFundo;
            tela = _tela;
        }

        private void Forms_ListaPokemon_Load(object sender, EventArgs e)
        {
            SetandoTelaTipoPokemon();
        }

        private void SetandoTelaTipoPokemon()
        {
            foreach (var VARIABLE in ApiPokemon.listaDadosPokemons1)
            {
                if (VARIABLE.tipo0 == tipo)
                {
                    pnlListaPokemon.Controls.Add(new Control_ImagemPokemon()
                    {
                        imagemPokemon = VARIABLE.imagem,
                        nomePokemon = VARIABLE.nome.ToUpper(),
                        corPictureBoxPokemon = corFundo,

                        nomeTipo0 = TraduzirTipo.TraduzirTipoPokemon(VARIABLE.tipo0),
                        corlblTipo0 = SetandoCorFundo.setandoCorFundo(VARIABLE.tipo0),

                        nomeTipo1 = TraduzirTipo.TraduzirTipoPokemon(VARIABLE.tipo1),
                        corlblTipo1 = SetandoCorFundo.setandoCorFundo(VARIABLE.tipo1)
                    });
                }
            }
        }

        private void Forms_ListaPokemon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}