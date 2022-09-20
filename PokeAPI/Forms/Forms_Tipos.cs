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
    public partial class Forms_Tipos : DevExpress.XtraEditors.XtraForm
    {
        public Forms_Tipos()
        {
            InitializeComponent();
        }

        private void AbrirListaTiposPokemon(string _tipo, Color _corFundo)
        {
            Forms_ListaPokemon listaPokemon = new Forms_ListaPokemon(_tipo, _corFundo, "Tipo Pokemon");
            listaPokemon.ShowDialog();

            this.Close();
        }

        private void pcbAgua_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("water", Color.FromArgb(0, 79, 202));
        }

        private void pcbVenenoso_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("poison", Color.FromArgb(225, 83, 127));
        }

        private void pcbTerrestre_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("ground", Color.FromArgb(240, 164, 33));
        }

        private void pcbPedra_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("rock", Color.FromArgb(169, 151, 122));
        }

        private void pcbNormal_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("normal", Color.FromArgb(115, 123, 131));
        }

        private void pcbGrama_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("grass", Color.FromArgb(0, 204, 21));
        }

        private void pcbLutador_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("fighting", Color.FromArgb(193, 72, 0));
        }

        private void pcbFada_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("fairy", Color.FromArgb(225, 65, 167));
        }

        private void pcbEletrico_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("electric", Color.FromArgb(255, 236, 14));
        }

        private void pcbSombrio_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("dark", Color.FromArgb(41, 63, 95));
        }

        private void pcbFogo_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("fire", Color.FromArgb(240, 68, 52));
        }

        private void pcbFantasma_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("ghost", Color.FromArgb(86, 0, 0));
        }

        private void pcbInseto_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("bug", Color.FromArgb(68, 191, 107));
        }

        private void pcbDragrao_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("dragon", Color.FromArgb(231, 197, 70));
        }

        private void pdbVoador_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("flying", Color.FromArgb(34, 220, 233));
        }

        private void pcbPsiquico_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("psychic", Color.FromArgb(112, 0, 190));
        }

        private void pcbGelo_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("ice", Color.FromArgb(119, 237, 255));
        }

        private void pcbAco_Click(object sender, EventArgs e)
        {
            AbrirListaTiposPokemon("steel", Color.FromArgb(113, 130, 137));
        }

        private void Forms_Tipos_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}