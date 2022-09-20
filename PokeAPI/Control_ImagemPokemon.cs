using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokeAPI.Forms;

namespace PokeAPI
{
    public partial class Control_ImagemPokemon : UserControl
    {
        public string imagemPokemon { get => pcbPokemon.ImageLocation; set => pcbPokemon.ImageLocation = value; }
        public string nomePokemon { get => lblNomePokemon.Text; set => lblNomePokemon.Text = value; }
        public Color corPictureBoxPokemon { get => pcbPokemon.BackColor; set => pcbPokemon.BackColor = value; }
        public Color corlblTipo0 { get => btnNomeTipo0.IdleFillColor; set => btnNomeTipo0.IdleFillColor = value; }
        public Color corlblTipo1 { get => btnNomeTipo1.IdleFillColor; set => btnNomeTipo1.IdleFillColor = value; }
        public string nomeTipo0 { get => btnNomeTipo0.Text; set => btnNomeTipo0.Text = value; }
        public string nomeTipo1 { get => btnNomeTipo1.Text; set => btnNomeTipo1.Text = value; }

        public Control_ImagemPokemon()
        {
            InitializeComponent();

            pcbBorda.Controls.Add(pcbPokemon);
            pcbBorda.Controls.Add(lblNomePokemon);
            pcbBorda.Controls.Add(btnNomeTipo0);
            pcbBorda.Controls.Add(btnNomeTipo1);
        }

        private Forms_ListaPokemon formsListaPokemon;

        private void pcbPokemon_Click(object sender, EventArgs e)
        {
            Forms_TelaInicial.nomePkemon = lblNomePokemon.Text;

            formsListaPokemon.Close();
        }
    }
}