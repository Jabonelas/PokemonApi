
namespace PokeAPI.Forms
{
    partial class Forms_ListaPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlListaPokemon = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlListaPokemon
            // 
            this.pnlListaPokemon.AutoScroll = true;
            this.pnlListaPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pnlListaPokemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlListaPokemon.Location = new System.Drawing.Point(22, 12);
            this.pnlListaPokemon.Name = "pnlListaPokemon";
            this.pnlListaPokemon.Size = new System.Drawing.Size(914, 358);
            this.pnlListaPokemon.TabIndex = 2;
            // 
            // Forms_ListaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::PokeAPI.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(959, 389);
            this.Controls.Add(this.pnlListaPokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Forms_ListaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms_ListaPokemon";
            this.Load += new System.EventHandler(this.Forms_ListaPokemon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_ListaPokemon_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel pnlListaPokemon;
    }
}