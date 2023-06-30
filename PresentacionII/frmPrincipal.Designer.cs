namespace PresentacionII
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.lblMenuSuperior = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tbFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.checkOrdenar = new System.Windows.Forms.CheckBox();
            this.cbOrdenPrecio = new System.Windows.Forms.ComboBox();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.timerFiltro = new System.Windows.Forms.Timer(this.components);
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.gbBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.lblSeleccione3 = new System.Windows.Forms.Label();
            this.lblSeleccione2 = new System.Windows.Forms.Label();
            this.lblSeleccione1 = new System.Windows.Forms.Label();
            this.lblDebeCompletar = new System.Windows.Forms.Label();
            this.lblValormaximo = new System.Windows.Forms.Label();
            this.lblValorminimo = new System.Windows.Forms.Label();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.checkRangoDePrecios = new System.Windows.Forms.CheckBox();
            this.btnBusquedaAvanzada = new FontAwesome.Sharp.IconButton();
            this.tbBusquedaAvanzada = new System.Windows.Forms.TextBox();
            this.cbCrterio3 = new System.Windows.Forms.ComboBox();
            this.cbCrterio2 = new System.Windows.Forms.ComboBox();
            this.cbCrterio1 = new System.Windows.Forms.ComboBox();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblBienvenida2 = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.toolTipSuperior = new System.Windows.Forms.ToolTip(this.components);
            this.ipbActualizar = new FontAwesome.Sharp.IconPictureBox();
            this.ipbCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblTag1 = new System.Windows.Forms.Label();
            this.lblTag2 = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.timerVolver = new System.Windows.Forms.Timer(this.components);
            this.lblVolver = new System.Windows.Forms.Label();
            this.lblVolver2 = new System.Windows.Forms.Label();
            this.timerVolver2 = new System.Windows.Forms.Timer(this.components);
            this.timerActualizar = new System.Windows.Forms.Timer(this.components);
            this.ipbIniciar = new FontAwesome.Sharp.IconPictureBox();
            this.ipbTag2 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbTag1 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbMano = new FontAwesome.Sharp.IconPictureBox();
            this.ipbInfo = new FontAwesome.Sharp.IconPictureBox();
            this.IPBArticulo = new FontAwesome.Sharp.IconPictureBox();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbBusquedaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            resources.ApplyResources(this.menuSuperior, "menuSuperior");
            this.menuSuperior.BackColor = System.Drawing.Color.MediumPurple;
            this.menuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuSuperior_MouseMove);
            // 
            // lblMenuSuperior
            // 
            resources.ApplyResources(this.lblMenuSuperior, "lblMenuSuperior");
            this.lblMenuSuperior.BackColor = System.Drawing.Color.MediumPurple;
            this.lblMenuSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuSuperior.Name = "lblMenuSuperior";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.MediumPurple;
            resources.ApplyResources(this.dgvArticulos, "dgvArticulos");
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tbFiltroRapido
            // 
            resources.ApplyResources(this.tbFiltroRapido, "tbFiltroRapido");
            this.tbFiltroRapido.Name = "tbFiltroRapido";
            this.tbFiltroRapido.TextChanged += new System.EventHandler(this.tbFiltroRapido_TextChanged);
            // 
            // lblFiltroRapido
            // 
            resources.ApplyResources(this.lblFiltroRapido, "lblFiltroRapido");
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            // 
            // checkOrdenar
            // 
            resources.ApplyResources(this.checkOrdenar, "checkOrdenar");
            this.checkOrdenar.Name = "checkOrdenar";
            this.checkOrdenar.UseVisualStyleBackColor = true;
            this.checkOrdenar.Click += new System.EventHandler(this.checkOrdenar_Click);
            // 
            // cbOrdenPrecio
            // 
            resources.ApplyResources(this.cbOrdenPrecio, "cbOrdenPrecio");
            this.cbOrdenPrecio.FormattingEnabled = true;
            this.cbOrdenPrecio.Name = "cbOrdenPrecio";
            this.cbOrdenPrecio.SelectedIndexChanged += new System.EventHandler(this.cbOrdenPrecio_SelectedIndexChanged);
            // 
            // lblCantidadRegistros
            // 
            resources.ApplyResources(this.lblCantidadRegistros, "lblCantidadRegistros");
            this.lblCantidadRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            // 
            // timerFiltro
            // 
            this.timerFiltro.Interval = 1000;
            this.timerFiltro.Tick += new System.EventHandler(this.timerFiltro_Tick);
            // 
            // lblSinResultados
            // 
            resources.ApplyResources(this.lblSinResultados, "lblSinResultados");
            this.lblSinResultados.Name = "lblSinResultados";
            // 
            // gbBusquedaAvanzada
            // 
            this.gbBusquedaAvanzada.Controls.Add(this.lblSeleccione3);
            this.gbBusquedaAvanzada.Controls.Add(this.lblSeleccione2);
            this.gbBusquedaAvanzada.Controls.Add(this.lblSeleccione1);
            this.gbBusquedaAvanzada.Controls.Add(this.lblDebeCompletar);
            this.gbBusquedaAvanzada.Controls.Add(this.lblValormaximo);
            this.gbBusquedaAvanzada.Controls.Add(this.lblValorminimo);
            this.gbBusquedaAvanzada.Controls.Add(this.tbMaximo);
            this.gbBusquedaAvanzada.Controls.Add(this.tbMinimo);
            this.gbBusquedaAvanzada.Controls.Add(this.checkRangoDePrecios);
            this.gbBusquedaAvanzada.Controls.Add(this.btnBusquedaAvanzada);
            this.gbBusquedaAvanzada.Controls.Add(this.tbBusquedaAvanzada);
            this.gbBusquedaAvanzada.Controls.Add(this.cbCrterio3);
            this.gbBusquedaAvanzada.Controls.Add(this.cbCrterio2);
            this.gbBusquedaAvanzada.Controls.Add(this.cbCrterio1);
            resources.ApplyResources(this.gbBusquedaAvanzada, "gbBusquedaAvanzada");
            this.gbBusquedaAvanzada.Name = "gbBusquedaAvanzada";
            this.gbBusquedaAvanzada.TabStop = false;
            // 
            // lblSeleccione3
            // 
            resources.ApplyResources(this.lblSeleccione3, "lblSeleccione3");
            this.lblSeleccione3.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeleccione3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeleccione3.Name = "lblSeleccione3";
            // 
            // lblSeleccione2
            // 
            resources.ApplyResources(this.lblSeleccione2, "lblSeleccione2");
            this.lblSeleccione2.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeleccione2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeleccione2.Name = "lblSeleccione2";
            // 
            // lblSeleccione1
            // 
            resources.ApplyResources(this.lblSeleccione1, "lblSeleccione1");
            this.lblSeleccione1.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeleccione1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeleccione1.Name = "lblSeleccione1";
            // 
            // lblDebeCompletar
            // 
            resources.ApplyResources(this.lblDebeCompletar, "lblDebeCompletar");
            this.lblDebeCompletar.BackColor = System.Drawing.SystemColors.Control;
            this.lblDebeCompletar.ForeColor = System.Drawing.Color.Crimson;
            this.lblDebeCompletar.Name = "lblDebeCompletar";
            // 
            // lblValormaximo
            // 
            resources.ApplyResources(this.lblValormaximo, "lblValormaximo");
            this.lblValormaximo.Name = "lblValormaximo";
            // 
            // lblValorminimo
            // 
            resources.ApplyResources(this.lblValorminimo, "lblValorminimo");
            this.lblValorminimo.Name = "lblValorminimo";
            // 
            // tbMaximo
            // 
            this.tbMaximo.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tbMaximo, "tbMaximo");
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaximo_KeyPress);
            // 
            // tbMinimo
            // 
            this.tbMinimo.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tbMinimo, "tbMinimo");
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinimo_KeyPress);
            // 
            // checkRangoDePrecios
            // 
            resources.ApplyResources(this.checkRangoDePrecios, "checkRangoDePrecios");
            this.checkRangoDePrecios.Name = "checkRangoDePrecios";
            this.checkRangoDePrecios.UseVisualStyleBackColor = true;
            this.checkRangoDePrecios.Click += new System.EventHandler(this.checkRangoDePrecios_Click);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBusquedaAvanzada, "btnBusquedaAvanzada");
            this.btnBusquedaAvanzada.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBusquedaAvanzada.IconColor = System.Drawing.Color.MediumPurple;
            this.btnBusquedaAvanzada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // tbBusquedaAvanzada
            // 
            this.tbBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbBusquedaAvanzada, "tbBusquedaAvanzada");
            this.tbBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbBusquedaAvanzada.Name = "tbBusquedaAvanzada";
            this.tbBusquedaAvanzada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbCrterio3
            // 
            this.cbCrterio3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCrterio3, "cbCrterio3");
            this.cbCrterio3.FormattingEnabled = true;
            this.cbCrterio3.Name = "cbCrterio3";
            this.cbCrterio3.SelectionChangeCommitted += new System.EventHandler(this.cbCrterio3_SelectionChangeCommitted);
            this.cbCrterio3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCrterio3_MouseClick_1);
            // 
            // cbCrterio2
            // 
            this.cbCrterio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCrterio2, "cbCrterio2");
            this.cbCrterio2.FormattingEnabled = true;
            this.cbCrterio2.Name = "cbCrterio2";
            this.cbCrterio2.SelectionChangeCommitted += new System.EventHandler(this.cbCrterio2_SelectionChangeCommitted);
            this.cbCrterio2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCrterio2_MouseClick);
            // 
            // cbCrterio1
            // 
            this.cbCrterio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCrterio1, "cbCrterio1");
            this.cbCrterio1.FormattingEnabled = true;
            this.cbCrterio1.Name = "cbCrterio1";
            this.cbCrterio1.SelectionChangeCommitted += new System.EventHandler(this.cbCrterio1_SelectionChangeCommitted);
            this.cbCrterio1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCrterio1_MouseClick);
            // 
            // tbDetalles
            // 
            this.tbDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbDetalles, "tbDetalles");
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.ReadOnly = true;
            // 
            // lblBienvenida
            // 
            resources.ApplyResources(this.lblBienvenida, "lblBienvenida");
            this.lblBienvenida.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblBienvenida.Name = "lblBienvenida";
            // 
            // lblBienvenida2
            // 
            resources.ApplyResources(this.lblBienvenida2, "lblBienvenida2");
            this.lblBienvenida2.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblBienvenida2.Name = "lblBienvenida2";
            // 
            // lblSeleccionado
            // 
            resources.ApplyResources(this.lblSeleccionado, "lblSeleccionado");
            this.lblSeleccionado.BackColor = System.Drawing.SystemColors.Control;
            this.lblSeleccionado.Name = "lblSeleccionado";
            // 
            // toolTipSuperior
            // 
            this.toolTipSuperior.AutomaticDelay = 100;
            this.toolTipSuperior.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // ipbActualizar
            // 
            this.ipbActualizar.BackColor = System.Drawing.Color.MediumPurple;
            this.ipbActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ipbActualizar.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.ipbActualizar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.ipbActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbActualizar.IconSize = 46;
            resources.ApplyResources(this.ipbActualizar, "ipbActualizar");
            this.ipbActualizar.Name = "ipbActualizar";
            this.ipbActualizar.TabStop = false;
            this.toolTipSuperior.SetToolTip(this.ipbActualizar, resources.GetString("ipbActualizar.ToolTip"));
            this.ipbActualizar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.ipbActualizar.MouseEnter += new System.EventHandler(this.ipbActualizar_MouseEnter);
            this.ipbActualizar.MouseLeave += new System.EventHandler(this.ipbActualizar_MouseLeave);
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
            resources.ApplyResources(this.ipbCerrar, "ipbCerrar");
            this.ipbCerrar.Name = "ipbCerrar";
            this.ipbCerrar.TabStop = false;
            this.toolTipSuperior.SetToolTip(this.ipbCerrar, resources.GetString("ipbCerrar.ToolTip"));
            this.ipbCerrar.Click += new System.EventHandler(this.ipbCerrar_Click);
            this.ipbCerrar.MouseEnter += new System.EventHandler(this.ipbCerrar_MouseEnter);
            this.ipbCerrar.MouseLeave += new System.EventHandler(this.ipbCerrar_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.MediumPurple;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Name = "btnAgregar";
            this.toolTipSuperior.SetToolTip(this.btnAgregar, resources.GetString("btnAgregar.ToolTip"));
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTag1
            // 
            resources.ApplyResources(this.lblTag1, "lblTag1");
            this.lblTag1.Name = "lblTag1";
            // 
            // lblTag2
            // 
            resources.ApplyResources(this.lblTag2, "lblTag2");
            this.lblTag2.Name = "lblTag2";
            // 
            // lblIniciar
            // 
            resources.ApplyResources(this.lblIniciar, "lblIniciar");
            this.lblIniciar.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblIniciar.Name = "lblIniciar";
            // 
            // timerVolver
            // 
            this.timerVolver.Interval = 1000;
            this.timerVolver.Tick += new System.EventHandler(this.timerVolver_Tick);
            // 
            // lblVolver
            // 
            resources.ApplyResources(this.lblVolver, "lblVolver");
            this.lblVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVolver.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Click += new System.EventHandler(this.lblVolver_Click);
            this.lblVolver.MouseLeave += new System.EventHandler(this.lblVolver_MouseLeave);
            this.lblVolver.MouseHover += new System.EventHandler(this.lblVolver_MouseHover);
            // 
            // lblVolver2
            // 
            resources.ApplyResources(this.lblVolver2, "lblVolver2");
            this.lblVolver2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblVolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVolver2.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblVolver2.Name = "lblVolver2";
            this.lblVolver2.Click += new System.EventHandler(this.lblVolver2_Click);
            this.lblVolver2.MouseLeave += new System.EventHandler(this.lblVolver2_MouseLeave);
            this.lblVolver2.MouseHover += new System.EventHandler(this.lblVolver2_MouseHover);
            // 
            // timerVolver2
            // 
            this.timerVolver2.Interval = 1300;
            this.timerVolver2.Tick += new System.EventHandler(this.timerVolver2_Tick);
            // 
            // timerActualizar
            // 
            this.timerActualizar.Interval = 200;
            this.timerActualizar.Tick += new System.EventHandler(this.timerActualizar_Tick);
            // 
            // ipbIniciar
            // 
            this.ipbIniciar.BackColor = System.Drawing.SystemColors.Control;
            this.ipbIniciar.ForeColor = System.Drawing.Color.MediumPurple;
            this.ipbIniciar.IconChar = FontAwesome.Sharp.IconChar.FlagCheckered;
            this.ipbIniciar.IconColor = System.Drawing.Color.MediumPurple;
            this.ipbIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbIniciar.IconSize = 28;
            resources.ApplyResources(this.ipbIniciar, "ipbIniciar");
            this.ipbIniciar.Name = "ipbIniciar";
            this.ipbIniciar.TabStop = false;
            // 
            // ipbTag2
            // 
            this.ipbTag2.BackColor = System.Drawing.SystemColors.Control;
            this.ipbTag2.ForeColor = System.Drawing.Color.MediumPurple;
            this.ipbTag2.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.ipbTag2.IconColor = System.Drawing.Color.MediumPurple;
            this.ipbTag2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbTag2.IconSize = 23;
            resources.ApplyResources(this.ipbTag2, "ipbTag2");
            this.ipbTag2.Name = "ipbTag2";
            this.ipbTag2.TabStop = false;
            // 
            // ipbTag1
            // 
            this.ipbTag1.BackColor = System.Drawing.SystemColors.Control;
            this.ipbTag1.ForeColor = System.Drawing.Color.MediumPurple;
            this.ipbTag1.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.ipbTag1.IconColor = System.Drawing.Color.MediumPurple;
            this.ipbTag1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbTag1.IconSize = 23;
            resources.ApplyResources(this.ipbTag1, "ipbTag1");
            this.ipbTag1.Name = "ipbTag1";
            this.ipbTag1.TabStop = false;
            // 
            // ipbMano
            // 
            this.ipbMano.BackColor = System.Drawing.SystemColors.Control;
            this.ipbMano.ForeColor = System.Drawing.Color.MediumPurple;
            this.ipbMano.IconChar = FontAwesome.Sharp.IconChar.HandsClapping;
            this.ipbMano.IconColor = System.Drawing.Color.MediumPurple;
            this.ipbMano.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMano.IconSize = 33;
            resources.ApplyResources(this.ipbMano, "ipbMano");
            this.ipbMano.Name = "ipbMano";
            this.ipbMano.TabStop = false;
            // 
            // ipbInfo
            // 
            this.ipbInfo.BackColor = System.Drawing.SystemColors.Control;
            this.ipbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ipbInfo.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbInfo.IconSize = 46;
            resources.ApplyResources(this.ipbInfo, "ipbInfo");
            this.ipbInfo.Name = "ipbInfo";
            this.ipbInfo.TabStop = false;
            // 
            // IPBArticulo
            // 
            resources.ApplyResources(this.IPBArticulo, "IPBArticulo");
            this.IPBArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.IPBArticulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IPBArticulo.IconColor = System.Drawing.Color.MediumPurple;
            this.IPBArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBArticulo.IconSize = 236;
            this.IPBArticulo.Name = "IPBArticulo";
            this.IPBArticulo.TabStop = false;
            // 
            // pbArticulo
            // 
            resources.ApplyResources(this.pbArticulo, "pbArticulo");
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCerrar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnEliminar.IconColor = System.Drawing.Color.MediumPurple;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnModificar.IconColor = System.Drawing.Color.MediumPurple;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReiniciar
            // 
            resources.ApplyResources(this.btnReiniciar, "btnReiniciar");
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnEliminarTodo
            // 
            resources.ApplyResources(this.btnEliminarTodo, "btnEliminarTodo");
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.pbLogo.Image = global::PresentacionII.Properties.Resources.nuevoLogo;
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblVolver2);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.ipbIniciar);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.ipbTag2);
            this.Controls.Add(this.lblTag2);
            this.Controls.Add(this.ipbTag1);
            this.Controls.Add(this.lblTag1);
            this.Controls.Add(this.ipbActualizar);
            this.Controls.Add(this.ipbCerrar);
            this.Controls.Add(this.lblBienvenida2);
            this.Controls.Add(this.ipbMano);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.tbDetalles);
            this.Controls.Add(this.ipbInfo);
            this.Controls.Add(this.gbBusquedaAvanzada);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.IPBArticulo);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.cbOrdenPrecio);
            this.Controls.Add(this.checkOrdenar);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.tbFiltroRapido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMenuSuperior);
            this.Controls.Add(this.menuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbBusquedaAvanzada.ResumeLayout(false);
            this.gbBusquedaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.Label lblMenuSuperior;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.TextBox tbFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.CheckBox checkOrdenar;
        private System.Windows.Forms.ComboBox cbOrdenPrecio;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.PictureBox pbArticulo;
        private FontAwesome.Sharp.IconPictureBox IPBArticulo;
        private System.Windows.Forms.Timer timerFiltro;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.GroupBox gbBusquedaAvanzada;
        private System.Windows.Forms.TextBox tbMaximo;
        private System.Windows.Forms.TextBox tbMinimo;
        private System.Windows.Forms.CheckBox checkRangoDePrecios;
        private FontAwesome.Sharp.IconButton btnBusquedaAvanzada;
        private System.Windows.Forms.TextBox tbBusquedaAvanzada;
        private System.Windows.Forms.ComboBox cbCrterio3;
        private System.Windows.Forms.ComboBox cbCrterio2;
        private System.Windows.Forms.ComboBox cbCrterio1;
        private System.Windows.Forms.Label lblValormaximo;
        private System.Windows.Forms.Label lblValorminimo;
        private System.Windows.Forms.Label lblDebeCompletar;
        private FontAwesome.Sharp.IconPictureBox ipbInfo;
        private System.Windows.Forms.TextBox tbDetalles;
        private System.Windows.Forms.Label lblBienvenida;
        private FontAwesome.Sharp.IconPictureBox ipbMano;
        private System.Windows.Forms.Label lblSeleccione1;
        private System.Windows.Forms.Label lblSeleccione3;
        private System.Windows.Forms.Label lblSeleccione2;
        private System.Windows.Forms.Label lblBienvenida2;
        private FontAwesome.Sharp.IconPictureBox ipbCerrar;
        private FontAwesome.Sharp.IconPictureBox ipbActualizar;
        private System.Windows.Forms.Label lblSeleccionado;
        public System.Windows.Forms.ToolTip toolTipSuperior;
        private System.Windows.Forms.Label lblTag1;
        private FontAwesome.Sharp.IconPictureBox ipbTag1;
        private FontAwesome.Sharp.IconPictureBox ipbTag2;
        private System.Windows.Forms.Label lblTag2;
        private FontAwesome.Sharp.IconPictureBox ipbIniciar;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Timer timerVolver;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.Label lblVolver2;
        private System.Windows.Forms.Timer timerVolver2;
        private System.Windows.Forms.Timer timerActualizar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

