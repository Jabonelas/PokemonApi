
namespace PokeAPI
{
    partial class Control_ImagemPokemon
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_ImagemPokemon));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblNomePokemon = new System.Windows.Forms.Label();
            this.pcbPokemon = new System.Windows.Forms.PictureBox();
            this.pcbBorda = new System.Windows.Forms.PictureBox();
            this.btnNomeTipo1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNomeTipo0 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomePokemon
            // 
            this.lblNomePokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomePokemon.AutoSize = true;
            this.lblNomePokemon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePokemon.ForeColor = System.Drawing.Color.White;
            this.lblNomePokemon.Location = new System.Drawing.Point(13, 9);
            this.lblNomePokemon.Name = "lblNomePokemon";
            this.lblNomePokemon.Size = new System.Drawing.Size(59, 23);
            this.lblNomePokemon.TabIndex = 2;
            this.lblNomePokemon.Text = "label1";
            // 
            // pcbPokemon
            // 
            this.pcbPokemon.BackColor = System.Drawing.Color.DarkRed;
            this.pcbPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbPokemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbPokemon.Location = new System.Drawing.Point(42, 39);
            this.pcbPokemon.Name = "pcbPokemon";
            this.pcbPokemon.Size = new System.Drawing.Size(175, 125);
            this.pcbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPokemon.TabIndex = 0;
            this.pcbPokemon.TabStop = false;
            this.pcbPokemon.Click += new System.EventHandler(this.pcbPokemon_Click);
            // 
            // pcbBorda
            // 
            this.pcbBorda.BackColor = System.Drawing.Color.Transparent;
            this.pcbBorda.Location = new System.Drawing.Point(1, 3);
            this.pcbBorda.Name = "pcbBorda";
            this.pcbBorda.Size = new System.Drawing.Size(256, 203);
            this.pcbBorda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBorda.TabIndex = 1;
            this.pcbBorda.TabStop = false;
            // 
            // btnNomeTipo1
            // 
            this.btnNomeTipo1.AllowAnimations = false;
            this.btnNomeTipo1.AllowMouseEffects = false;
            this.btnNomeTipo1.AllowToggling = false;
            this.btnNomeTipo1.AnimationSpeed = 200;
            this.btnNomeTipo1.AutoGenerateColors = false;
            this.btnNomeTipo1.AutoRoundBorders = false;
            this.btnNomeTipo1.AutoSizeLeftIcon = true;
            this.btnNomeTipo1.AutoSizeRightIcon = true;
            this.btnNomeTipo1.BackColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo1.BackColor1 = System.Drawing.Color.DarkGray;
            this.btnNomeTipo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNomeTipo1.BackgroundImage")));
            this.btnNomeTipo1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo1.ButtonText = "NomeTipo";
            this.btnNomeTipo1.ButtonTextMarginLeft = 0;
            this.btnNomeTipo1.ColorContrastOnClick = 45;
            this.btnNomeTipo1.ColorContrastOnHover = 45;
            this.btnNomeTipo1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNomeTipo1.CustomizableEdges = borderEdges1;
            this.btnNomeTipo1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNomeTipo1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNomeTipo1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNomeTipo1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNomeTipo1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNomeTipo1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomeTipo1.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomeTipo1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNomeTipo1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNomeTipo1.IconMarginLeft = 11;
            this.btnNomeTipo1.IconPadding = 10;
            this.btnNomeTipo1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNomeTipo1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNomeTipo1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNomeTipo1.IconSize = 25;
            this.btnNomeTipo1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo1.IdleBorderRadius = 30;
            this.btnNomeTipo1.IdleBorderThickness = 1;
            this.btnNomeTipo1.IdleFillColor = System.Drawing.Color.DarkGray;
            this.btnNomeTipo1.IdleIconLeftImage = null;
            this.btnNomeTipo1.IdleIconRightImage = null;
            this.btnNomeTipo1.IndicateFocus = false;
            this.btnNomeTipo1.Location = new System.Drawing.Point(143, 170);
            this.btnNomeTipo1.Name = "btnNomeTipo1";
            this.btnNomeTipo1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNomeTipo1.OnDisabledState.BorderRadius = 30;
            this.btnNomeTipo1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo1.OnDisabledState.BorderThickness = 1;
            this.btnNomeTipo1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNomeTipo1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNomeTipo1.OnDisabledState.IconLeftImage = null;
            this.btnNomeTipo1.OnDisabledState.IconRightImage = null;
            this.btnNomeTipo1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNomeTipo1.onHoverState.BorderRadius = 30;
            this.btnNomeTipo1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo1.onHoverState.BorderThickness = 1;
            this.btnNomeTipo1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNomeTipo1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo1.onHoverState.IconLeftImage = null;
            this.btnNomeTipo1.onHoverState.IconRightImage = null;
            this.btnNomeTipo1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo1.OnIdleState.BorderRadius = 30;
            this.btnNomeTipo1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo1.OnIdleState.BorderThickness = 1;
            this.btnNomeTipo1.OnIdleState.FillColor = System.Drawing.Color.DarkGray;
            this.btnNomeTipo1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo1.OnIdleState.IconLeftImage = null;
            this.btnNomeTipo1.OnIdleState.IconRightImage = null;
            this.btnNomeTipo1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNomeTipo1.OnPressedState.BorderRadius = 30;
            this.btnNomeTipo1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo1.OnPressedState.BorderThickness = 1;
            this.btnNomeTipo1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNomeTipo1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo1.OnPressedState.IconLeftImage = null;
            this.btnNomeTipo1.OnPressedState.IconRightImage = null;
            this.btnNomeTipo1.Size = new System.Drawing.Size(94, 30);
            this.btnNomeTipo1.TabIndex = 44;
            this.btnNomeTipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNomeTipo1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNomeTipo1.TextMarginLeft = 0;
            this.btnNomeTipo1.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNomeTipo1.UseDefaultRadiusAndThickness = true;
            // 
            // btnNomeTipo0
            // 
            this.btnNomeTipo0.AllowAnimations = false;
            this.btnNomeTipo0.AllowMouseEffects = false;
            this.btnNomeTipo0.AllowToggling = false;
            this.btnNomeTipo0.AnimationSpeed = 200;
            this.btnNomeTipo0.AutoGenerateColors = false;
            this.btnNomeTipo0.AutoRoundBorders = false;
            this.btnNomeTipo0.AutoSizeLeftIcon = true;
            this.btnNomeTipo0.AutoSizeRightIcon = true;
            this.btnNomeTipo0.BackColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo0.BackColor1 = System.Drawing.Color.DarkGray;
            this.btnNomeTipo0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNomeTipo0.BackgroundImage")));
            this.btnNomeTipo0.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo0.ButtonText = "NomeTipo";
            this.btnNomeTipo0.ButtonTextMarginLeft = 0;
            this.btnNomeTipo0.ColorContrastOnClick = 45;
            this.btnNomeTipo0.ColorContrastOnHover = 45;
            this.btnNomeTipo0.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNomeTipo0.CustomizableEdges = borderEdges2;
            this.btnNomeTipo0.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNomeTipo0.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNomeTipo0.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNomeTipo0.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNomeTipo0.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNomeTipo0.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomeTipo0.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo0.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomeTipo0.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNomeTipo0.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNomeTipo0.IconMarginLeft = 11;
            this.btnNomeTipo0.IconPadding = 10;
            this.btnNomeTipo0.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNomeTipo0.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNomeTipo0.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNomeTipo0.IconSize = 25;
            this.btnNomeTipo0.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo0.IdleBorderRadius = 30;
            this.btnNomeTipo0.IdleBorderThickness = 1;
            this.btnNomeTipo0.IdleFillColor = System.Drawing.Color.DarkGray;
            this.btnNomeTipo0.IdleIconLeftImage = null;
            this.btnNomeTipo0.IdleIconRightImage = null;
            this.btnNomeTipo0.IndicateFocus = true;
            this.btnNomeTipo0.Location = new System.Drawing.Point(9, 170);
            this.btnNomeTipo0.Name = "btnNomeTipo0";
            this.btnNomeTipo0.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNomeTipo0.OnDisabledState.BorderRadius = 30;
            this.btnNomeTipo0.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo0.OnDisabledState.BorderThickness = 1;
            this.btnNomeTipo0.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNomeTipo0.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNomeTipo0.OnDisabledState.IconLeftImage = null;
            this.btnNomeTipo0.OnDisabledState.IconRightImage = null;
            this.btnNomeTipo0.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNomeTipo0.onHoverState.BorderRadius = 30;
            this.btnNomeTipo0.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo0.onHoverState.BorderThickness = 1;
            this.btnNomeTipo0.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNomeTipo0.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo0.onHoverState.IconLeftImage = null;
            this.btnNomeTipo0.onHoverState.IconRightImage = null;
            this.btnNomeTipo0.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNomeTipo0.OnIdleState.BorderRadius = 30;
            this.btnNomeTipo0.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo0.OnIdleState.BorderThickness = 1;
            this.btnNomeTipo0.OnIdleState.FillColor = System.Drawing.Color.DarkGray;
            this.btnNomeTipo0.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo0.OnIdleState.IconLeftImage = null;
            this.btnNomeTipo0.OnIdleState.IconRightImage = null;
            this.btnNomeTipo0.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNomeTipo0.OnPressedState.BorderRadius = 30;
            this.btnNomeTipo0.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNomeTipo0.OnPressedState.BorderThickness = 1;
            this.btnNomeTipo0.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNomeTipo0.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNomeTipo0.OnPressedState.IconLeftImage = null;
            this.btnNomeTipo0.OnPressedState.IconRightImage = null;
            this.btnNomeTipo0.Size = new System.Drawing.Size(94, 30);
            this.btnNomeTipo0.TabIndex = 43;
            this.btnNomeTipo0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNomeTipo0.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNomeTipo0.TextMarginLeft = 0;
            this.btnNomeTipo0.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNomeTipo0.UseDefaultRadiusAndThickness = true;
            // 
            // Control_ImagemPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNomeTipo1);
            this.Controls.Add(this.btnNomeTipo0);
            this.Controls.Add(this.lblNomePokemon);
            this.Controls.Add(this.pcbPokemon);
            this.Controls.Add(this.pcbBorda);
            this.Name = "Control_ImagemPokemon";
            this.Size = new System.Drawing.Size(257, 209);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pcbPokemon;
        private System.Windows.Forms.PictureBox pcbBorda;
        public System.Windows.Forms.Label lblNomePokemon;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNomeTipo1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNomeTipo0;
    }
}
