
namespace PokeAPI.Forms
{
    partial class Forms_TelaCarregamento
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
            this.pcbCarregando = new DevExpress.XtraEditors.PictureEdit();
            this.pcbLoanding = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoanding.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarregando
            // 
            this.pcbCarregando.EditValue = global::PokeAPI.Properties.Resources.CarregandoPokemon2;
            this.pcbCarregando.Location = new System.Drawing.Point(-1, -1);
            this.pcbCarregando.Name = "pcbCarregando";
            this.pcbCarregando.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pcbCarregando.Properties.Appearance.Options.UseBackColor = true;
            this.pcbCarregando.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbCarregando.Size = new System.Drawing.Size(644, 453);
            this.pcbCarregando.TabIndex = 19;
            // 
            // pcbLoanding
            // 
            this.pcbLoanding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbLoanding.EditValue = global::PokeAPI.Properties.Resources.CarregandoLoading5;
            this.pcbLoanding.Location = new System.Drawing.Point(588, 414);
            this.pcbLoanding.Name = "pcbLoanding";
            this.pcbLoanding.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pcbLoanding.Properties.Appearance.Options.UseBackColor = true;
            this.pcbLoanding.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoanding.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.pcbLoanding.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoanding.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.pcbLoanding.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoanding.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.pcbLoanding.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcbLoanding.Properties.Caption.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoanding.Properties.Caption.Appearance.Options.UseBackColor = true;
            this.pcbLoanding.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcbLoanding.Size = new System.Drawing.Size(54, 17);
            this.pcbLoanding.TabIndex = 20;
            // 
            // Forms_TelaCarregamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.pcbLoanding);
            this.Controls.Add(this.pcbCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forms_TelaCarregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms_TelaCarregamento";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoanding.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pcbCarregando;
        private DevExpress.XtraEditors.PictureEdit pcbLoanding;
    }
}