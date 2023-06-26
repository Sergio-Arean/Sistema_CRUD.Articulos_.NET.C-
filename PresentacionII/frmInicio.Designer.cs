namespace PresentacionII
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnIngresar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipbCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.MediumPurple;
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnIngresar.ForeColor = System.Drawing.SystemColors.Window;
            btnIngresar.Location = new System.Drawing.Point(97, 176);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(248, 37);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(159, 49);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 121);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Gestión de Artículos ";
            // 
            // ipbCerrar
            // 
            this.ipbCerrar.BackColor = System.Drawing.Color.MediumPurple;
            this.ipbCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbCerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ipbCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ipbCerrar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.ipbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbCerrar.IconSize = 46;
            this.ipbCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ipbCerrar.Location = new System.Drawing.Point(397, 0);
            this.ipbCerrar.Name = "ipbCerrar";
            this.ipbCerrar.Size = new System.Drawing.Size(46, 46);
            this.ipbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipbCerrar.TabIndex = 37;
            this.ipbCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.ipbCerrar, "Cerrar");
            this.ipbCerrar.Click += new System.EventHandler(this.ipbCerrar_Click);
            this.ipbCerrar.MouseEnter += new System.EventHandler(this.ipbCerrar_MouseEnter);
            this.ipbCerrar.MouseLeave += new System.EventHandler(this.ipbCerrar_MouseLeave);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(443, 46);
            this.menuTitulo.TabIndex = 38;
            this.menuTitulo.Text = "menuStrip1";
            this.menuTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuTitulo_MouseMove);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(443, 224);
            this.ControlBox = false;
            this.Controls.Add(this.ipbCerrar);
            this.Controls.Add(btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTitulo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ipbCerrar;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}