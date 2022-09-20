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
using DevExpress.XtraEditors.Controls;

namespace PokeAPI.Forms
{
    public partial class Forms_TelaInicial : DevExpress.XtraEditors.XtraForm
    {
        private int indicePokemon = 1;
        private ApiPokemon Api = new ApiPokemon();

        public static string nomePkemon = string.Empty;

        public Forms_TelaInicial()
        {
            InitializeComponent();

            VerificarIndiceColocandoImagem();
        }

        private void btnTipoPokemon_Click(object sender, EventArgs e)
        {
            BuscarTipoPokemon();
        }

        private void btnBuscarPokemonPorNome_Click(object sender, EventArgs e)
        {
            PreencherDadosPokemonNome(txtNomePokemon.Text.ToLower());
        }

        private void btnPokemonProximo_Click(object sender, EventArgs e)
        {
            indicePokemon += 1;

            VerificarIndiceColocandoImagem();

            PegandoDadosProximoPokemon(indicePokemon);

            PegandoDadosAnteriorPokemon(indicePokemon);
        }

        private void btnPokemonAnterior_Click(object sender, EventArgs e)
        {
            indicePokemon -= 1;

            VerificarIndiceColocandoImagem();

            PegandoDadosProximoPokemon(indicePokemon);
            PegandoDadosAnteriorPokemon(indicePokemon);
        }

        private void txtNomePokemon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }

        private void txtNomePokemon_KeyUp(object sender, KeyEventArgs e)
        {
            txtNomePokemon.Text.ToLower();
        }

        private void Forms_TelaInicial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BuscarTipoPokemon()
        {
            Forms_Tipos listaPokemon = new Forms_Tipos();
            listaPokemon.ShowDialog();

            if (nomePkemon != string.Empty)
            {
                PreencherDadosPokemonNome(nomePkemon.ToLower());
            }
        }

        private void PreencherDadosPokemonNome(string _pokemon)
        {
            try
            {
                DadosPokemon listaDadosPokemons = ApiPokemon.listaDadosPokemons1.First(x => x.nome.Equals(_pokemon));
                SetandoDadosPokemon(listaDadosPokemons);

                SetandoStatus(listaDadosPokemons);

                Api.BuscarLinkEvolucao(listaDadosPokemons.indice);

                SetantandoDadosEvolucaoPokemon();

                PegandoDadosProximoPokemon(listaDadosPokemons.indice);

                PegandoDadosAnteriorPokemon(listaDadosPokemons.indice);

                indicePokemon = listaDadosPokemons.indice;
            }
            catch (Exception e)
            {
                MessageBox.Show("Pokemon Não Encotrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencherDadosPokemonIndice(int _indice)
        {
            DadosPokemon listaDadosPokemons = ApiPokemon.listaDadosPokemons1.First(x => x.indice.Equals(_indice));

            SetandoStatus(listaDadosPokemons);

            Api.BuscarLinkEvolucao(_indice);

            SetantandoDadosEvolucaoPokemon();

            SetandoDadosPokemon(listaDadosPokemons);
        }

        private void SetandoStatus(DadosPokemon _listaDadosPokemons)
        {
            long HP = _listaDadosPokemons.valorHP;
            long Ataque = _listaDadosPokemons.valorAtaque;
            long Defesa = _listaDadosPokemons.valorDefesa;
            long AtaqueEspecial = _listaDadosPokemons.valorAtaqueEspecial;
            long DefesaEspecial = _listaDadosPokemons.valorDefesaEspecial;
            long Velocidade = _listaDadosPokemons.valorVelocidade;

            rclHP.Position = Convert.ToInt32(HP);
            rclAtaque.Position = Convert.ToInt32(Ataque);
            rclDefesa.Position = Convert.ToInt32(Defesa);
            rclAtaqueEspecial.Position = Convert.ToInt32(AtaqueEspecial);
            rclDefesaEspecial.Position = Convert.ToInt32(DefesaEspecial);
            rclVelocidade.Position = Convert.ToInt32(Velocidade);
        }

        private void SetandoDadosPokemon(DadosPokemon _listaDadosPokemons)
        {
            pcbPokemonPrincipal.ImageLocation = _listaDadosPokemons.imagem;

            string TextDadosPokemonPrincipal = $"{_listaDadosPokemons.nome} - Nº {_listaDadosPokemons.indice}";
            var upper = char.ToUpper(TextDadosPokemonPrincipal[0]) + TextDadosPokemonPrincipal.Substring(1);
            lblNomePokemon.Text = upper;

            btnNomeTipo0.Text = TraduzirTipo.TraduzirTipoPokemon(_listaDadosPokemons.tipo0);
            btnNomeTipo0.IdleFillColor = SetandoCorFundo.setandoCorFundo(_listaDadosPokemons.tipo0);

            if (_listaDadosPokemons.tipo1 != null)
            {
                btnNomeTipo1.Text = TraduzirTipo.TraduzirTipoPokemon(_listaDadosPokemons.tipo1);
                btnNomeTipo1.IdleFillColor = SetandoCorFundo.setandoCorFundo(_listaDadosPokemons.tipo1);

                btnNomeTipo1.Visible = true;
            }
            else
            {
                btnNomeTipo1.Visible = false;
            }

            CalcularAltura(_listaDadosPokemons.altura);

            CalcularPeso(_listaDadosPokemons.peso);
        }

        private void CalcularPeso(decimal _valorPeso)
        {
            decimal calcularPeso = _valorPeso / 10;

            txtPeso.Text = $"{calcularPeso} kg";
        }

        private void CalcularAltura(decimal _valorAltura)
        {
            decimal calcularAltura = _valorAltura / 10;

            txtAltura.Text = $"{calcularAltura} m";
        }

        private void VerificarIndiceColocandoImagem()
        {
            if (indicePokemon > 0 && indicePokemon <= 898)
            {
                PreencherDadosPokemonIndice(indicePokemon);
            }
            else if (indicePokemon > 898)
            {
                indicePokemon = 1;

                PreencherDadosPokemonIndice(indicePokemon);
            }
            else if (indicePokemon <= 0)
            {
                indicePokemon = 898;

                PreencherDadosPokemonIndice(indicePokemon);
            }
        }

        private void SetantandoDadosEvolucaoPokemon()
        {
            pnlEvolucaoPokemon.Controls.Clear();

            foreach (var item in ApiPokemon.nomesPokemon)
            {
                foreach (var VARIABLE in ApiPokemon.listaDadosPokemons1)
                {
                    if (VARIABLE.nome == item)
                    {
                        pnlEvolucaoPokemon.Controls.Add(new Control_ImagemPokemon()
                        {
                            imagemPokemon = VARIABLE.imagem,
                            nomePokemon = VARIABLE.nome.ToUpper(),
                            corPictureBoxPokemon = SetandoCorFundo.setandoCorFundo(VARIABLE.tipo0),

                            nomeTipo0 = TraduzirTipo.TraduzirTipoPokemon(VARIABLE.tipo0),
                            corlblTipo0 = SetandoCorFundo.setandoCorFundo(VARIABLE.tipo0),

                            nomeTipo1 = TraduzirTipo.TraduzirTipoPokemon(VARIABLE.tipo1),
                            corlblTipo1 = SetandoCorFundo.setandoCorFundo(VARIABLE.tipo1)
                        });

                        break;
                    }
                }
            }
        }

        private void PegandoDadosProximoPokemon(int _proximoPokemon)
        {
            _proximoPokemon = _proximoPokemon + 1;

            if (_proximoPokemon > 898)
            {
                _proximoPokemon = 1;
            }

            foreach (DadosPokemon item in ApiPokemon.listaDadosPokemons1)
            {
                if (item.indice == _proximoPokemon)
                {
                    string TextoBotao = $"{item.nome} - Nº {item.indice}";
                    var upper = char.ToUpper(TextoBotao[0]) + TextoBotao.Substring(1);

                    btnPokemonProximo.Text = $"     {upper}";

                    break;
                }
            }
        }

        private void PegandoDadosAnteriorPokemon(int _anteriorPokemon)
        {
            _anteriorPokemon = _anteriorPokemon - 1;

            if (_anteriorPokemon < 1)
            {
                _anteriorPokemon = 898;
            }

            foreach (DadosPokemon item in ApiPokemon.listaDadosPokemons1)
            {
                if (item.indice == _anteriorPokemon)
                {
                    string TextoBotao = $"{item.nome} - Nº {item.indice}";
                    var upper = char.ToUpper(TextoBotao[0]) + TextoBotao.Substring(1);

                    btnPokemonAnterior.Text = $"     {upper}";

                    break;
                }
            }
        }
    }
}