namespace PresentacionII
{
    partial class frmAgregarModificar
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
            FontAwesome.Sharp.IconButton btnAceptar;
            FontAwesome.Sharp.IconButton btnCancelar;
            this.btnAgregarImg = new FontAwesome.Sharp.IconButton();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.IPBArticulo = new FontAwesome.Sharp.IconPictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.toolTipAgregarImagen = new System.Windows.Forms.ToolTip(this.components);
            btnAceptar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBArticulo)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAceptar.IconColor = System.Drawing.Color.Black;
            btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAceptar.Location = new System.Drawing.Point(151, 658);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(143, 52);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCancelar.IconColor = System.Drawing.Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new System.Drawing.Point(340, 658);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(143, 52);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAgregarImg.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnAgregarImg.FlatAppearance.BorderSize = 100;
            this.btnAgregarImg.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAgregarImg.IconColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarImg.IconSize = 26;
            this.btnAgregarImg.Location = new System.Drawing.Point(166, 462);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(34, 30);
            this.btnAgregarImg.TabIndex = 7;
            this.toolTipAgregarImagen.SetToolTip(this.btnAgregarImg, "Agregar Imagen");
            this.btnAgregarImg.UseVisualStyleBackColor = false;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(37, 311);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(185, 31);
            this.cbMarca.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(38, 235);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(185, 31);
            this.cbCategoria.TabIndex = 3;
            // 
            // separatorLabel
            // 
            this.separatorLabel.AutoSize = true;
            this.separatorLabel.Location = new System.Drawing.Point(33, 68);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(189, 16);
            this.separatorLabel.TabIndex = 20;
            this.separatorLabel.Text = "__________________________";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(34, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.MediumPurple;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbCodigo.ForeColor = System.Drawing.Color.LightGray;
            this.tbCodigo.Location = new System.Drawing.Point(39, 53);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(185, 25);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Text = "Ingrese Código";
            this.tbCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbCodigo_MouseClick);
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(335, 178);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(254, 261);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 35;
            this.pbArticulo.TabStop = false;
            // 
            // IPBArticulo
            // 
            this.IPBArticulo.BackColor = System.Drawing.Color.MediumPurple;
            this.IPBArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IPBArticulo.IconColor = System.Drawing.SystemColors.ControlText;
            this.IPBArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBArticulo.IconSize = 236;
            this.IPBArticulo.Location = new System.Drawing.Point(342, 191);
            this.IPBArticulo.Name = "IPBArticulo";
            this.IPBArticulo.Size = new System.Drawing.Size(256, 236);
            this.IPBArticulo.TabIndex = 36;
            this.IPBArticulo.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.MediumPurple;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbNombre.ForeColor = System.Drawing.Color.LightGray;
            this.tbNombre.Location = new System.Drawing.Point(43, 150);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(185, 25);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.Text = "Ingrese Nombre";
            this.tbNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbNombre_MouseClick);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(38, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 23);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "__________________________";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.MediumPurple;
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbDescripcion.ForeColor = System.Drawing.Color.LightGray;
            this.tbDescripcion.Location = new System.Drawing.Point(37, 401);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(191, 25);
            this.tbDescripcion.TabIndex = 5;
            this.tbDescripcion.Text = "Ingrese Descripción";
            this.tbDescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDescripcion_MouseClick);
            this.tbDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescripcion_KeyPress);
            this.tbDescripcion.Leave += new System.EventHandler(this.tbDescripcion_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 369);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 23);
            this.lblDescripcion.TabIndex = 40;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "__________________________";
            // 
            // tbUrlImagen
            // 
            this.tbUrlImagen.BackColor = System.Drawing.Color.MediumPurple;
            this.tbUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUrlImagen.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbUrlImagen.ForeColor = System.Drawing.Color.LightGray;
            this.tbUrlImagen.Location = new System.Drawing.Point(39, 494);
            this.tbUrlImagen.Name = "tbUrlImagen";
            this.tbUrlImagen.Size = new System.Drawing.Size(185, 25);
            this.tbUrlImagen.TabIndex = 6;
            this.tbUrlImagen.Text = "Ingrese URL";
            this.tbUrlImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbUrlImagen_MouseClick);
            this.tbUrlImagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrlImagen_KeyPress);
            this.tbUrlImagen.Leave += new System.EventHandler(this.tbUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrlImagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.Transparent;
            this.lblUrlImagen.Location = new System.Drawing.Point(34, 462);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(126, 23);
            this.lblUrlImagen.TabIndex = 43;
            this.lblUrlImagen.Text = "URL Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "__________________________";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.MediumPurple;
            this.tbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbPrecio.ForeColor = System.Drawing.Color.LightGray;
            this.tbPrecio.Location = new System.Drawing.Point(42, 585);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(185, 25);
            this.tbPrecio.TabIndex = 8;
            this.tbPrecio.Text = "Ingrese Precio";
            this.tbPrecio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPrecio_MouseClick);
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            this.tbPrecio.Leave += new System.EventHandler(this.tbPrecio_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(37, 553);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(71, 23);
            this.lblPrecio.TabIndex = 46;
            this.lblPrecio.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "__________________________";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Location = new System.Drawing.Point(36, 209);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(108, 23);
            this.lblCategoria.TabIndex = 49;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Transparent;
            this.lblMarca.Location = new System.Drawing.Point(36, 285);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(73, 23);
            this.lblMarca.TabIndex = 50;
            this.lblMarca.Text = "Marca";
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.lblMarca);
            this.panelTotal.Controls.Add(this.lblCategoria);
            this.panelTotal.Controls.Add(this.tbPrecio);
            this.panelTotal.Controls.Add(this.lblPrecio);
            this.panelTotal.Controls.Add(this.label4);
            this.panelTotal.Controls.Add(this.tbUrlImagen);
            this.panelTotal.Controls.Add(this.lblUrlImagen);
            this.panelTotal.Controls.Add(this.label8);
            this.panelTotal.Controls.Add(this.tbDescripcion);
            this.panelTotal.Controls.Add(this.lblDescripcion);
            this.panelTotal.Controls.Add(this.label6);
            this.panelTotal.Controls.Add(this.tbNombre);
            this.panelTotal.Controls.Add(this.lblNombre);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Controls.Add(this.IPBArticulo);
            this.panelTotal.Controls.Add(this.pbArticulo);
            this.panelTotal.Controls.Add(this.tbCodigo);
            this.panelTotal.Controls.Add(this.lblCodigo);
            this.panelTotal.Controls.Add(this.separatorLabel);
            this.panelTotal.Controls.Add(this.cbCategoria);
            this.panelTotal.Controls.Add(this.cbMarca);
            this.panelTotal.Controls.Add(this.btnAgregarImg);
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(650, 722);
            this.panelTotal.TabIndex = 0;
            this.panelTotal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTotal_MouseMove);
            // 
            // frmAgregarModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(649, 722);
            this.ControlBox = false;
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(this.panelTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarModificar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmAgregarModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBArticulo)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregarImg;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.PictureBox pbArticulo;
        private FontAwesome.Sharp.IconPictureBox IPBArticulo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.ToolTip toolTipAgregarImagen;
    }
}