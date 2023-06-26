using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using dominio;
using negocio;
using MessageBox = System.Windows.Forms.MessageBox;


namespace PresentacionII
{
    public partial class frmPrincipal : Form
    {
        Articulo seleccionado = null; //prueba
        private List<Articulo> listaArticulos;
        private List<Articulo> listaFiltrada;
        private ArticuloNegocio articuloNegocio;
        private int posY = 0;
        private int posX = 0;




        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        //Carga formulario principal
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                VisibilidadImagenEmoji(false);
                CambiarIPB(-1);
                ActualizarGrilla();
                CargarComboBox();
                SetearLabelsValores(false);
                SetearLabelCompletarCampo(false);
                SetearLabelCantidadRegistros();
                SetearLblDetalles(1);
                MostrarSaludo(true);
                SetearLblTagsBusqueda(false);
                


                lblVolver.Visible = false;
                cbCrterio2.SelectedIndex = -1;
                dgvArticulos.ClearSelection();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetearLblTagsBusqueda(Boolean v)
        {
            //este metodo setea los tags de busqueda para q si aparecen,
            //contengan las etiquetas que reflejen los criterios de busqueda
            
            try
            {
                if (v)
                {
                   if(cbCrterio1.SelectedIndex!=-1 && cbCrterio1.SelectedItem.ToString() != "Nombre")
                    {
                        lblTag1.Text = cbCrterio2.Text;
                        lblTag1.Visible = true;
                        ipbTag1.Visible = true;
                        if (cbCrterio3.SelectedItem.ToString() != "Todos")
                        {
                            lblTag2.Text = cbCrterio3.Text;
                            lblTag2.Visible = true;
                            ipbTag2.Visible = true;
                        }
                        
                    }

                }
                else
                {
                    lblTag1.Text = "";
                    lblTag2.Text = "";
                    lblTag1.Visible = false;
                    lblTag2.Visible = false;

                    ipbTag1.Visible = false;
                    ipbTag2.Visible = false;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        private void InhabilitarCombosBox()
        {
            cbCrterio2.Enabled = false;
            cbCrterio3.Enabled = false;
            lblSeleccione2.Visible = false;
            lblSeleccione3.Visible= false;
            lblDebeCompletar.Visible = false;

            cbCrterio2.SelectedIndex = -1;
            cbCrterio3.SelectedIndex= -1;
        }

        private void SetearLabelCantidadRegistros()
        {
            
        }

        /// <summary>
        /// Establece la visibilidad entre la imagen del articulo y el emoji, haciendo que si uno aparece, el otro permanezca oculto, y viceversa.
        /// </summary>
        /// <param name="v">Bool que representa si la imagen de articulo debe priorizarse respecto del icono(emoji)</param>
        private void VisibilidadImagenEmoji(bool v)
        {
            //con este metodo seteamos la relacion de visibilidad entre el emoji y la imagen del articulo
            //ya que ambos son opuestos... cuando uno aparece el otro debe estar invisible y viceversa
            if (v)
            {
                lblVolver.Visible = false;
                pbArticulo.Visible = true;
                IPBArticulo.Visible = false;
                
            }
            else
            {
                pbArticulo.Visible = false;
                IPBArticulo.Visible = true;
            }
        }

        private void MostrarSaludo(bool x)
        {
            //en este metodo seteamos los mensajes de bienvenida con sus correspondientes emojis
            if (x)
            {
                ipbMano.Visible = true;
                lblBienvenida.Visible = true;
            }
            else
            {
                ipbMano.Visible = false;
                lblBienvenida.Visible = false;
            }
        }

        private void VisibilidadSugerenciaInicial()
        {
            //este metodo determina que sugerencia dar al usuario, segun haya o no articulos en grilla
            if (dgvArticulos.Rows.Count > 0)
            {
                lblIniciar.Visible = false;
                ipbIniciar.Visible = false;

                lblBienvenida2.Visible = true;
                

            }
            else
            {
                lblBienvenida2.Visible = false;
                


                lblIniciar.Visible = true;
                ipbIniciar.Visible = true;

            }
        }

        private void SetearLabelCompletarCampo(bool x)
        {
            if (x)
            {
                lblSeleccione3.Visible = false;
                lblDebeCompletar.Visible = true;
            }
            else
            {
               lblDebeCompletar.Visible= false;
            }


            
        }

        private void SetearLabelsValores(bool x)
        {
            if (x)
            {
                lblValorminimo.Visible = true;
                lblValormaximo.Visible = true;
            }
            else
            {
                lblValorminimo.Visible = false;
                lblValormaximo.Visible = false;
            }
        }

       /* private void SetearPB(bool x)
        {
            //si esta en true, el ipb esta activo, y el pb esta en falso
            if (x)
            {
                pbArticulo.Visible = false;
                IPBInicial.Visible = true;
            }
            else
            {
                IPBInicial.Visible = false;
                pbArticulo.Visible = true;   
            }

        }
       */
        private void SetearBotones(bool x)
        {
            //este metodo setea los botones de modificar y eliminar segun parametro
            if (x)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

            }

            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }

        }

        //Metodos mas generales
        //1ra version del metodo. si no carga la url en cuestion busca una img de la nube de img rota
        /*
        private void CargarImagen(string texto_url)
        {
            
            try
            {
                pbArticulo.Load(texto_url);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("http://www.terminalbb.com.ar/assets/camaleon_cms/image-not-found-4a963b95bf081c3ea02923dceaeb3f8085e1a654fc54840aac61a57a60903fef.png");
                //throw ex;
            }


        }*/
        /// <summary>
        /// Carga la imagen asociada al articulo segun la url enviada por parametro.. De presentarse algun error, carga un icono generico.
        /// </summary>
        private void CargarImagen(string texto_url)
        {
            
            try
            {
                VisibilidadImagenEmoji(true);
                pbArticulo.Load(texto_url);
            }
            catch (Exception ex)
            {
                VisibilidadImagenEmoji(false);
                IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Image;
            }


        }
        /// <summary>
        /// Cuenta e informa en pantalla la cantidad de registros presentes en la tabla de articulos.
        /// </summary>
        private void ContarRegistros()
        {
            int encontrados = dgvArticulos.RowCount;
            lblCantidadRegistros.Text = "Cantidad de Registros: " + encontrados.ToString();

        }

        /// <summary>
        /// Segun el valor booleano enviado por parametro, informa si la busqueda realizada presenta o no resultados.
        /// </summary>
        private void SinResultados (bool x)
        {
            if (x)
            {
                lblSinResultados.Visible = true;
            }
            else 
            {
                lblSinResultados.Visible = false;
            }
            
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenURL"].Visible = false;

        }


        private void CargarComboBox()
        {
            SetearComboBox();

            cbOrdenPrecio.Items.Add("Menor precio");
            cbOrdenPrecio.Items.Add("Mayor precio");

            //ComboBox de Busqueda Avanzada:
            string[] criterios = { "Categoría", "Marca", "Nombre"};
            cbCrterio1.DataSource = criterios;


            //combo box sin seleccion
            cbCrterio1.SelectedIndex = -1;
            cbCrterio2.SelectedIndex = -1;




           
        }

        private void SetearComboBox()
        {
            cbCrterio1.SelectedIndex= -1;

        }

        public void ActualizarGrilla()
        {
            try
            {
                lblVolver2.Visible = false;
                VisibilidadImagenEmoji(false);
                tbFiltroRapido.Text = "";
                SetearLblTagsBusqueda(false);
                lblVolver.Visible = false;
                DeshabilitarTimers();
                HaySeleccionado();
                



                //IPB
                if (!lblBienvenida.Visible == true) //habra lupa solo si no estoy al principio
                {
                    CambiarIPB(2); 
                }
                

                // de una lista actualizada en BBDD a dgv
                articuloNegocio = new ArticuloNegocio();
                listaArticulos = articuloNegocio.ListarArticulos();


                //el check de ordenacion esta vigente?
                if (cbOrdenPrecio.Enabled)
                {
                    OrdenarLista();
                }

                dgvArticulos.DataSource = listaArticulos;
                listaFiltrada = null;

                //limpiar columnas
                OcultarColumnas();
                ContarRegistros();
                dgvArticulos.ClearSelection();
                SetearBotones(false);
                SugerirVerDetalles();

                SetearLblDetalles(1); //cuadro de detalles vacio
                HabilitarTextoBusqueda(false);
                SetearCombosCriteriosBusqueda();
                InhabilitarCombosBox();
                VisibilidadSugerenciaInicial();
                LimpiarBusquedaPorRango();



            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Limpia los campos correspondientes a la busqueda por rango de precios
        /// </summary>
        private void LimpiarBusquedaPorRango()
        {
            checkRangoDePrecios.Checked = false;
            tbMinimo.Text = "";
            tbMaximo.Text = "";
            tbMinimo.Enabled = false;
            tbMaximo.Enabled = false;
        }



        private void SetearCombosCriteriosBusqueda()
        {
            //Set de combobox de criterios de seleccion vacios
            cbCrterio1.SelectedIndex = -1;
            cbCrterio2.SelectedIndex = -1;
            cbCrterio3.SelectedIndex = -1;

            //Set de indicacion de seleccionar el 1er criterio
            lblSeleccione1.Visible = true;
            lblSeleccione2.Visible = false;
            lblSeleccione3.Visible = false;
            
        }

        private void DeshabilitarTimers()
        {
            //en este metodo deshabilitamos timers, para evitar procesamientos innecesarios
            timerFiltro.Enabled = false;
            timerVolver.Enabled = false;
            timerVolver2.Enabled = false;
            timerActualizar.Enabled = false;
        }

        private void HaySeleccionado()
        {

            if (seleccionado == null)
            {
                lblSeleccionado.BackColor = System.Drawing.Color.Red;

            }
            else
            {
                lblSeleccionado.BackColor = System.Drawing.Color.LawnGreen;
            }
        }

        private void OrdenarLista()
        {
            if (cbOrdenPrecio.SelectedIndex == 0)
                articuloNegocio.OrdenarListaAscendente(listaArticulos);

            else
                articuloNegocio.OrdenarListaDescendente(listaArticulos);
        }

        //Eventos

        private void cbOrdenPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //XLQE, hay que ordenar lista y tambien cambiar data grid view    
            if (cbOrdenPrecio.SelectedIndex == 0)
            {

                if (listaFiltrada != null)
                {
                    dgvArticulos.DataSource = null;
                    articuloNegocio.OrdenarListaAscendente(listaFiltrada);
                    dgvArticulos.DataSource = listaFiltrada;
                }
                else
                {
                    dgvArticulos.DataSource = null;
                    articuloNegocio.OrdenarListaAscendente(listaArticulos);
                    dgvArticulos.DataSource = listaArticulos;
                }

            }
            else
            {
                if (listaFiltrada != null)
                {
                    dgvArticulos.DataSource = null;
                    articuloNegocio.OrdenarListaDescendente(listaFiltrada);
                    dgvArticulos.DataSource = listaFiltrada;
                }
                else
                {
                    dgvArticulos.DataSource = null;
                    articuloNegocio.OrdenarListaDescendente(listaArticulos);
                    dgvArticulos.DataSource = listaArticulos;
                }

            }
            OcultarColumnas();
            ContarRegistros();
            dgvArticulos.ClearSelection();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarSaludo(false);
                ActualizarGrilla();
                SetearLblDetalles(3);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            //busqueda rapida apd dgv... es decir sin acceder a la BBDD

            try
            {
                
                dgvArticulos.DataSource = null;
                if (tbFiltroRapido.Text != "")
                {
                    lblVolver.Visible = false;
                    SetearLblDetalles(1); //se borra el cuadro de informacion
                    lblBienvenida2.Visible = false; //se borra sugerencia de detalles
                    VisibilidadImagenEmoji(false); //vuelvo a mostrar el emoji y escondo imagen
                    MostrarSaludo(false);
                    CambiarIPB(0);
                    articuloNegocio = new ArticuloNegocio();
                    listaFiltrada = articuloNegocio.DevuelveListaFiltrada(listaArticulos, tbFiltroRapido.Text);
                    dgvArticulos.DataSource = listaFiltrada;
                    OcultarColumnas();
                    ContarRegistros();
                    InformarResultados_BusquedaRapida();

                    //lblVolver.Text = "Limpiar";
                    timerVolver.Enabled = true;
                    dgvArticulos.ClearSelection();

                }
                else
                {
                    //lblVolver.Text = "Volver";
                    SetearBotones(false);
                    SetearLblDetalles(1); //borramos cuadro de informacion

                    if (dgvArticulos.RowCount > 0) //si hay registros cargados en el dgv, sugiero hacer click
                    {
                        SetearLblDetalles(0);
                        
                    }

                    ActualizarGrilla();
                    VisibilidadImagenEmoji(false);
                    dgvArticulos.ClearSelection();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void InformarResultados_BusquedaRapida()
        {
            string texto;
            int cantidad = dgvArticulos.Rows.Count;


            try
            {
                if (cantidad==0)
                {
                    texto = "No se han encontrado coincidencias.";
                }
                else
                {
                    if (cantidad == 1)
                    {
                        texto = "Se ha encontrado una coincidencia.";
                    }
                    else
                    {
                        texto = "Se han encontrado " + cantidad + " coincidencias.";
                    }
                }

                tbDetalles.Text = texto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CambiarIPB(int valor)
        {
            //valor -1 : el emoji de bienvenida inicial
            //valor 0 : de puntos suspensivos a deducir si ya hubo una busqueda exitosa
            //valor 1 : hacia los puntos suspensivos
            //valor 2 : hacia la lupa (icono por defecto)
            
            switch (valor)
            {
                case -1:

                        IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.LaughBeam;
                        break;
                case 0:
                        SinResultados(false);
                        IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Ellipsis; //pusimos ...
                        timerFiltro.Enabled = true; //activamos temporizador y en el evento tick evaluamos q carita poner
                        break;
                case 1:
                        SinResultados(false);
                        IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
                        break;

                case 2:
                        SinResultados(false);
                        IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;

                        break;
                default:
                    break;
            }
            

        }

        

        private void SetearLblDetalles(byte valor)
        {
            //con este metodo seteamos el texto para sugerir ver detalles en el cuadro(textbox) de informacion


            //Valor 0: se quita el saludo inicial, y se sugiere ver detalles
            //Valor 1: se deja vacio el cuadro de informacion (textbox)
            //valor 2: informamos que no hemos encontrado resultados
            //valor 3: informamos que los datos han sido actualizados

            //el lbl detalles, fuera de este contexto, se gestiona cuando cambia la seleccion del datagridview,
            //evento selectionchanged.

            switch (valor)
            {
                case 0:
                    MostrarSaludo(false);
                    tbDetalles.Text = "Seleccione artículo para ver detalles";
                    break;

                case 1:
                    tbDetalles.Text = "";
                    break;

                case 2:
                    tbDetalles.Text = "No se han encontrado coincidencias";
                    break;

                case 3:
                    tbDetalles.Text = "¡Los datos han sido actualizados!";
                    break;

                default:
                    break;
            }
        }

        private void timerFiltro_Tick(object sender, EventArgs e)
        {
            if (tbFiltroRapido.Text != "")
            {
                if (dgvArticulos.RowCount != 0)
                {
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Check;
                    SinResultados(false);
                    lblBienvenida2.Visible = true;

                    
                }

                else
                {
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.FaceSadTear;
                    SinResultados(true);
                    SetearLblDetalles(2); //informamos que no hay coincidencias
                    
                    
                }

                if (seleccionado == null)
                {
                    SetearBotones(false);
                }
            }


        }

        private void checkOrdenar_Click(object sender, EventArgs e)
        {

            //pendiente: que al destiquear, la lista anteriormente ordenada vuelva a estar estandar,sin ordenar
            if (checkOrdenar.Checked)
            {
                cbOrdenPrecio.Enabled = true; //habilita combobox
            }
            else
            {
                cbOrdenPrecio.Enabled = false;//habilita combobox
                ActualizarGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbDetalles.Text = ""; //limpiar textbox de detalles al agregar un articulo nuevo...
            frmAgregarModificar formulario = new frmAgregarModificar();
            AperturaVentana(true,"Nuevo Artículo");
            
            
            formulario.ShowDialog();

            AperturaVentana(false, "Catálogo de Artículos");
            ActualizarGrilla();
        }

        private void AperturaVentana(bool apertura,string titulo)
        {
            /**este metodo, segun parametros recibidos, da nombre transitorio al titulo del formulario, segun
            que ventana fue abierta. O bien setea los valores que debe tener el formulario por defecto
            **/

            if (apertura)
            {
                MostrarSaludo(false);
                VisibilidadImagenEmoji(false);
                IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
                lblMenuSuperior.Text = titulo;
                lblMenuSuperior.BackColor = System.Drawing.Color.Silver;
                menuSuperior.BackColor = System.Drawing.Color.Silver;
                ipbActualizar.BackColor = System.Drawing.Color.Silver;
                ipbCerrar.BackColor = System.Drawing.Color.Silver;

            }
            else
            {
                lblMenuSuperior.Text = titulo;
                lblMenuSuperior.BackColor = System.Drawing.Color.MediumPurple;
                menuSuperior.BackColor = System.Drawing.Color.MediumPurple;
                ipbActualizar.BackColor = System.Drawing.Color.MediumPurple;
                ipbCerrar.BackColor = System.Drawing.Color.MediumPurple;

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //validar! se estima que en la inteligencia de botones modificar y eliminar esto se resuelve
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarModificar formulario = new frmAgregarModificar(seleccionado);
                AperturaVentana(true, "Modificar Artículo");

                formulario.ShowDialog();

                AperturaVentana(false, "Catálogo de Artículos");


            if (tbFiltroRapido.Text == "")
            {
                ActualizarGrilla();
            }
            

            dgvArticulos.ClearSelection(); 
            SetearBotones(false);
            VisibilidadImagenEmoji(false);
            CambiarIPB(2);
           



        }

        

        private void dgvArticulos_RowEnter(object sender, DataGridViewCellEventArgs e) //eliminar
        {
           // MessageBox.Show("este es el evento row enter!");
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)//eliminar
        {
            //MessageBox.Show("este es el evento cell content click!");

            


        }

        private void dgvArticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ///MessageBox.Show("este es el evento cell enter!");
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                DemorarAparicionLblVolver2();
                MostrarSaludo(false);
                VisibilidadImagenEmoji(true);
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                HaySeleccionado(); //transitorio
                SetearBotones(true);
                tbDetalles.Text = seleccionado.Descripcion; 
                CargarImagen(seleccionado.ImagenUrl);

                
                SetearLblTagsBusqueda(false);
                lblVolver.Visible = false;
                timerVolver.Enabled = false;
                if (listaFiltrada != null)
                {
                    lblVolver2.Visible = true;
                    //que aparezca boton de volver
                    //MessageBox.Show("Estas en una busqueda");
                }
                else
                {
                    lblVolver2.Visible = false;
                    //MessageBox.Show("No estas buscando nada");
                }
                DeshabilitarTimers();
                lblBienvenida2.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void DemorarAparicionLblVolver2()
        {
            lblVolver2.Visible = false;
            timerVolver2.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio = new ArticuloNegocio();
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                DialogResult rta = MessageBox.Show("¿Eliminar?", seleccionado.Nombre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(rta==DialogResult.Yes)
                {
                    articuloNegocio.EliminarArticulo(seleccionado.Id);
                    MessageBox.Show("El artículo " + seleccionado.Nombre + " ha sido eliminado.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                    ActualizarGrilla();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           

        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Este es el evento mouse enter!");
            //DebeSeleccionar();

            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //TENER EN CUENTA QUE ESTE EVENTO SE DISPARA AL PRINCIPIO
               // MessageBox.Show("Este es el evento selection changed");
                if(dgvArticulos.CurrentRow != null)
                {
                    
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    if (pbArticulo.Visible == true) //PRUEBA! la idea es que si hay un emoji adelante,no cargue ni el detalle ni la foto
                    {
                        tbDetalles.Text = seleccionado.Descripcion;
                        CargarImagen(seleccionado.ImagenUrl); //COMENTADO PORQUE SE REALENTIZA
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbCrterio1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbCrterio3.Enabled = false; 
            //cbCrterio2.SelectedIndex = -1;
            cbCrterio2.Enabled = true;
            lblSeleccione1.Visible = false;
            lblSeleccione2.Visible = true;
            //MessageBox.Show("este es el evento selection commited");

            //Seteo de labels seleccione
            cbCrterio2.Enabled = true;
            lblSeleccione1.Visible = false;
            lblSeleccione2.Visible = true;

            //Carga de 2do y 3er Combobox (2do criterio)
            CargarCriterios();

            //Me aseguro que si usuario aun no eligio, no se carguen automaticamente los combobox
            cbCrterio2.SelectedIndex = -1;
            cbCrterio3.SelectedIndex = -1;

        }

        private void CargarCriterios()
        {
            //metodo para cargar los distintos combobox de los criterios segun usuario elige en busqueda avanzada
            CategoriaNegocio categoriaNegocio;
            MarcaNegocio marcaNegocio;

            try
            {

                    if (cbCrterio1.SelectedItem.ToString() == "Nombre")
                    {
                        string[] criterios = { "Comienza con", "Termina con", "Contiene" };
                        cbCrterio2.DataSource = criterios;
                        HabilitarTextoBusqueda(true);
                        SetearLabelCompletarCampo(true);
                    // DeshabilitarLabelsSeleccione();
                        lblSeleccione3.Visible = false;

                        
                    }
                    else if (cbCrterio1.SelectedItem.ToString() == "Categoría")
                    {
                        //Listar Categorias en el 2do combobox
                        categoriaNegocio = new CategoriaNegocio();
                        cbCrterio2.DataSource = categoriaNegocio.listarCategorias();
                        
                        //Seteo del 3er criterio (marcas)
                        HabilitarTextoBusqueda(false);
                        SetearLabelCompletarCampo(false);

                        
                        marcaNegocio = new MarcaNegocio();
                        List<string> listaDeMarcas = marcaNegocio.listarNombres();

                        cbCrterio3.Items.Clear(); //vacio el combobox al usar un add para el "todos"
                        cbCrterio3.Items.Add("Todos");
                        foreach (string item in listaDeMarcas)
                        {
                            cbCrterio3.Items.Add(item);
                        }

                    }
                    else //Uusario elige como 1er criterio "Marca"
                    {

                        //Seteo de marcas en 2do combobox
                        marcaNegocio = new MarcaNegocio();
                        cbCrterio2.DataSource = marcaNegocio.listarMarcas();
                        HabilitarTextoBusqueda(false);
                        SetearLabelCompletarCampo(false);


                        //Seteo del 3er criterio (Categorias)
                        categoriaNegocio = new CategoriaNegocio();
                        List<string> listaDeCategorias = categoriaNegocio.listarNombres();

                        cbCrterio3.Items.Clear();
                        cbCrterio3.Items.Add("Todos"); //vacio el combobox al usar un add para el "todos"
                         foreach (string item in listaDeCategorias)
                        {
                            cbCrterio3.Items.Add(item);
                        }

                        //DeshabilitarLabelsSeleccione();
                    }

                
                //cbCrterio2.SelectedIndex = -1;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void cbCrterio2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbCrterio3.SelectedIndex = -1;
            lblSeleccione2.Visible = false;
            cbCrterio3.Enabled = true;
            if (cbCrterio1.SelectedItem.ToString() != "Nombre")
            {
                lblSeleccione3.Visible = true;
            }
            
        }

        private void cbCrterio3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblSeleccione3.Visible = false;
        }

        private void cbCrterio1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("este es el evento selected index change");
            /*
            CategoriaNegocio categoriaNegocio;
            MarcaNegocio marcaNegocio;
            
            //aca se regulan los combobox segundos PERO TAMBIEN LOS 3ROS
            try
            {
                if (cbCrterio1.SelectedIndex != -1) {          
                if (cbCrterio1.SelectedValue.ToString() == "Nombre")
                {
                    string[] criterios = { "Comienza con", "Termina con", "Contiene" };
                    cbCrterio2.DataSource = criterios;
                    HabilitarTextoBusqueda(true);
                    SetearLabelCompletarCampo(true);
                    DeshabilitarLabelsSeleccione();
                }
                else if (cbCrterio1.SelectedValue.ToString() == "Categoría")
                {
                    categoriaNegocio = new CategoriaNegocio();
                    cbCrterio2.DataSource = categoriaNegocio.listarCategorias();
                    HabilitarTextoBusqueda(false);
                    SetearLabelCompletarCampo(false);
                    


                        //3er combobox debe ir con Marcas
                        //vacio el combobox ya que usare un add para el "todos"
                        marcaNegocio = new MarcaNegocio();
                    List <string> listaDeMarcas = marcaNegocio.listarNombres();

                    cbCrterio3.Items.Clear();
                    cbCrterio3.Items.Add("Todos");
                    foreach (string item in listaDeMarcas)
                    {
                        cbCrterio3.Items.Add(item);
                    }
                        
                }
                else
                {
                    marcaNegocio = new MarcaNegocio();
                    cbCrterio2.DataSource = marcaNegocio.listarMarcas();
                    HabilitarTextoBusqueda(false);
                    SetearLabelCompletarCampo(false);
                    

                    //3er combobox deben ir las categorias
                    categoriaNegocio = new CategoriaNegocio();
                    List<string> listaDeCategorias = categoriaNegocio.listarNombres();

                    cbCrterio3.Items.Clear();
                    cbCrterio3.Items.Add("Todos");
                    foreach (string item in listaDeCategorias)
                    {
                        cbCrterio3.Items.Add(item);
                    }

                        DeshabilitarLabelsSeleccione();
                    }
                    
                }
                cbCrterio2.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }*/
            
        }

        private void DeshabilitarLabelsSeleccione()
        {
            lblSeleccione1.Visible = false;
            lblSeleccione2.Visible = false;
        }

        private void HabilitarTextoBusqueda(bool x)
        {
            tbBusquedaAvanzada.Text = "";
            if (x)
            {
                cbCrterio3.Visible = false;
                tbBusquedaAvanzada.Visible = true;
                
            }
            else
            {
                cbCrterio3.Visible = true;
                tbBusquedaAvanzada.Visible = false;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBusquedaAvanzada.Text))
            {
                SetearLabelCompletarCampo(true);
            }
            else
            {
                SetearLabelCompletarCampo(false);
            }
        }

        private void cbCrterio2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkRangoDePrecios_Click(object sender, EventArgs e)
        {
            //evento click para el rango de precios
            if(checkRangoDePrecios.Checked)
            {
                tbMinimo.Enabled = true;
                tbMaximo.Enabled = true;
                SetearLabelsValores(true);
                
            }
            else
            {
                tbMinimo.Text = "";
                tbMaximo.Text = "";
                tbMinimo.Enabled = false;
                tbMaximo.Enabled = false;
                SetearLabelsValores(false);
            }
        }

        private void btnPruebasTransitorias_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            int resultado = marcanegocio.devuelveCantidadMarcas();
            MessageBox.Show("El resultado de esta prueba es " + resultado);
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {

            //llamado a metodo que devuelve la lista filtrada cambiando el data source
            articuloNegocio = new ArticuloNegocio();
            string criterio1, criterio2, criterio3;
            string valor_minimo = "";
            string valor_maximo = "";
            bool minimo, maximo;

            try
            {
                VisibilidadImagenEmoji(false);
                lblVolver.Visible = false;
                CambiarIPB(0);

                if (ValidarBusquedaAvanzada() == false)
                {
                    
                    return;
                }

                criterio1 = SetearCriterio1(cbCrterio1.SelectedValue.ToString()); //x tema de tildes
                criterio2 = cbCrterio2.SelectedItem.ToString();

                if (cbCrterio3.Visible == true) //el criterio3 varia si es un tb o bien un cbox
                {
                    criterio3 = cbCrterio3.SelectedItem.ToString();
                    
                }
                else
                {
                    criterio3 = tbBusquedaAvanzada.Text;
                }


                ///VALIDACIONES EN ALGUN LADO !

                //Seteo dentro del evento con ayuda de metodo
                minimo = SetearValorMinimo();
                maximo = SetearValorMaximo();

                if (minimo)
                {
                    valor_minimo = tbMinimo.Text;
                }
                if (maximo)
                {
                    valor_maximo = tbMaximo.Text;
                }



                string consulta = articuloNegocio.SetearConsultaAvanzada(criterio1, criterio2, criterio3, minimo, maximo, valor_minimo.Replace(",", "."), valor_maximo.Replace(",", "."));
                 MessageBox.Show(consulta);


                //Personalizando el dgv una vez que los resultados son devueltos...
                dgvArticulos.DataSource = null;
                listaFiltrada = articuloNegocio.listar_BusquedaAvanzada(consulta); //asigno a la lista filtrada , x si llega a haber ordenacion
                dgvArticulos.DataSource = listaFiltrada;
                OcultarColumnas();
                ContarRegistros();

                //Seteando lo que informamos al usuario
                MostrarSaludo(false);
                //InformarResultados();
                InformarResultadosConEtiquetas();
                SugerirVerDetalles();
                SetearBotones(false);
                dgvArticulos.ClearSelection();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
 

        private bool ValidarBusquedaAvanzada()
        {
            if(cbCrterio1.SelectedIndex < 0) // si en el 1er criterio el usuario no puso nada, logicamente despues tampoco(revisar)
            {
                EnRojoLosIncompletos();
                MessageBox.Show("Debe seleccionar algún criterio de búsqueda","Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cbCrterio2.SelectedIndex < 0) //si el 2do criterio no esta seleccionado
            {
                lblSeleccione2.ForeColor = System.Drawing.Color.Crimson;
                if (!(cbCrterio1.SelectedValue.ToString() == "Nombre"))//si no eligio nombre, valido lo que pasa con categoria y marca
                {
                    if (cbCrterio1.SelectedItem.ToString() == "Marca")
                    {
                        MessageBox.Show("Debe seleccionar Marca", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar Categoría", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Debe especificar algún criterio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if(cbCrterio3.SelectedIndex < 0 && cbCrterio1.SelectedItem.ToString()!="Nombre")
                {
                    lblSeleccione3.ForeColor = System.Drawing.Color.Crimson;
                    if (cbCrterio1.SelectedValue.ToString() == "Categoría")
                    {
                         MessageBox.Show("Debe seleccionar Marca", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return false;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar Categoría", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    
                }
            else
            {
                if (cbCrterio1.SelectedItem.ToString() == "Nombre")
                {
                    if(tbBusquedaAvanzada.Visible && string.IsNullOrEmpty(tbBusquedaAvanzada.Text))
                    {
                        MessageBox.Show("El filtro de búsqueda está vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
           
            }
            return true;
        }
        

        private void EnRojoLosIncompletos()
        {
            if (cbCrterio1.SelectedIndex < 0)
            {
                lblSeleccione1.ForeColor = System.Drawing.Color.Crimson;
            }
            if (cbCrterio2.SelectedIndex < 0)
            {
                lblSeleccione2.ForeColor = System.Drawing.Color.Crimson;
            }
            if(cbCrterio3.SelectedIndex < 0)
            {
               lblSeleccione3.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        private void InformarResultadosConEtiquetas()
        {

            string texto;
            timerVolver.Enabled = true;
            try
            {
                if (dgvArticulos.RowCount == 0)
                {
                    lblSinResultados.Visible = true;
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.FaceSadTear;

                    if (cbCrterio1.SelectedItem.ToString() == "Nombre")
                    {
                        if (cbCrterio2.SelectedItem.ToString() == "Comienza con")
                        {
                            texto = "No se han encontrado artículos que comiencen con '" + tbBusquedaAvanzada.Text + "'";
                        }
                        else if (cbCrterio2.SelectedItem.ToString() == "Termina con")
                        {
                            texto = "No se han encontrado artículos que terminen con '" + tbBusquedaAvanzada.Text + "'";
                        }
                        else
                        {
                            texto = "No se han encontrado artículos que contengan '" + tbBusquedaAvanzada.Text + "'";
                        }
                    }
                    else
                    {
                        texto = "No se han encontrado coincidencias.";
                        SetearLblTagsBusqueda(true);
                    }

                    /*if ((tbMinimo.Text != "") || (tbMaximo.Text != ""))
                    {
                        texto += " en el rango seleccionado.";
                    }*/
                }
                else
                {
                    SetearLblTagsBusqueda(true);
                    if (dgvArticulos.RowCount == 1)
                    {
                        texto = "Se ha encontrado una coincidencia.";
                    }
                    else
                    {
                        texto = "Se han encontrado " + dgvArticulos.RowCount.ToString() + " coincidencias.";
                    }
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Check;
                    lblSinResultados.Visible = false;

                }

                tbDetalles.Text = texto;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void InformarResultados()
        {
            try
            {
                string texto;
                timerVolver.Enabled = true;
                if (dgvArticulos.RowCount == 0)
                {
                    lblSinResultados.Visible = true;
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.FaceSadTear;
                    SetearLblTagsBusqueda(false);




                    if (cbCrterio1.SelectedItem.ToString() == "Categoría") //TILDES?
                    {
                        if (cbCrterio3.SelectedItem.ToString() == "Todos")
                        {
                            texto = "No se ha encontrado " + cbCrterio2.SelectedItem.ToString();
                        }
                        else
                        {
                            texto = "No se ha encontrado " + cbCrterio2.SelectedItem.ToString() + " " + cbCrterio3.SelectedItem.ToString();
                        }
                    }
                    else if (cbCrterio1.SelectedItem.ToString() == "Marca")
                    {
                        if (cbCrterio3.SelectedItem.ToString() == "Todos")
                        {
                            texto = "No se ha encontrado artículos de marca " + cbCrterio2.SelectedItem.ToString();
                        }
                        else
                        {
                            texto = "No se ha encontrado " + cbCrterio3.SelectedItem.ToString() + " " + cbCrterio2.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        if (cbCrterio2.SelectedItem.ToString() == "Comienza con")
                        {
                            texto = "No se han encontrado artículos que comiencen con '" + tbBusquedaAvanzada.Text + "'";
                        }
                        else if (cbCrterio2.SelectedItem.ToString() == "Termina con")
                        {
                            texto = "No se han encontrado artículos que terminen con '" + tbBusquedaAvanzada.Text + "'";
                        }
                        else
                        {
                            texto = "No se han encontrado artículos que contengan '" + tbBusquedaAvanzada.Text + "'";
                        }
                    }
                    /*if ((tbMinimo.Text != "") || (tbMaximo.Text != ""))
                    {
                        texto += " en el rango seleccionado.";
                    }*/

                }
                else
                {
                    SetearLblTagsBusqueda(true);
                    if (dgvArticulos.RowCount == 1)
                    {
                        texto = "Se ha encontrado una coincidencia";
                    }
                    else
                    {
                        texto = "Se han encontrado " + dgvArticulos.RowCount.ToString() + " coincidencias";
                    }
                    IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Check;
                    lblSinResultados.Visible = false;

                }

                tbDetalles.Text = texto;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void SugerirVerDetalles()
        {
            //este metodo sugiere al usuario ver detalles de articulo cuando el datagridview tiene contenido
            if(dgvArticulos.Rows.Count > 0)
            {
                lblBienvenida2.Visible = true;
                
            }
            else
            {
                lblBienvenida2.Visible = false;
               
            }
        }

        /// <summary>
        /// Verifica que el usuario haya pulsado el check de rango de valor correspondiente y asegura que el valor ingresado sea valido
        /// </summary>
        /// <returns>true, si el checkbox se encuentra pulsado y el campo correspondiente tiene un valor valido</returns>
        private bool SetearValorMaximo()
        {
            if (checkRangoDePrecios.Checked && (!string.IsNullOrEmpty(tbMaximo.Text))) //check chequeado y hay valor aceptable
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool SetearValorMinimo()
        {
            if(checkRangoDePrecios.Checked && (!string.IsNullOrEmpty(tbMinimo.Text))) //check chequeado y hay valor aceptable
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private string SetearCriterio1(string criterio_elegido)
        {
            if (criterio_elegido == "Categoría")
            {
                return "Categoria";
            }
            else
            {
                return criterio_elegido;
            }
        }

        private void menuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tbBusquedaAvanzada_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrilla();
                
                SimularProcesamientoAlActualizar();

                MostrarSaludo(false);
                
                dgvArticulos.ClearSelection();
                
                VisibilidadImagenEmoji(false);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        ///  Busca que cuando el usuario aprieta el boton actualizar,ademas de actualizar, algunos elementos del form cambien su apariencia por un momento,para darle mayor apariencia de procesamiento y que el usuario se asegure de que los datos efectivamente se actualizaron al haber hecho click.
        /// </summary>
        private void SimularProcesamientoAlActualizar()
        {
            tbDetalles.Text = "";
            lblBienvenida2.Visible = false;
            IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            timerActualizar.Enabled = true;

        }

        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            
            ActualizarGrilla();
            SetearLblDetalles(3);
            

        }

        private void ipbActualizar_MouseEnter(object sender, EventArgs e)
        {
            ipbActualizar.BackColor = System.Drawing.SystemColors.MenuText;
          
            
            
        }

        private void ipbActualizar_MouseLeave(object sender, EventArgs e)
        {
            ipbActualizar.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void ipbCerrar_MouseEnter(object sender, EventArgs e)
        {
            ipbCerrar.BackColor = System.Drawing.Color.Crimson;
        }

        private void ipbCerrar_MouseLeave(object sender, EventArgs e)
        {
            ipbCerrar.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void ipbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Cerrar Aplicación?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cbCrterio1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }



        private void timerVolver_Tick(object sender, EventArgs e)
        {
           
            lblVolver.Visible = true;

        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }
         
        private void lblVolver_MouseHover(object sender, EventArgs e)
        {
            lblVolver.BackColor = System.Drawing.Color.MediumPurple;
            lblVolver.ForeColor = System.Drawing.Color.GhostWhite;
        }

        private void lblVolver_MouseLeave(object sender, EventArgs e)
        {
            lblVolver.BackColor =  System.Drawing.SystemColors.ControlLight;
            lblVolver.ForeColor = System.Drawing.Color.MediumPurple;
        }

        private void lblVolver2_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void lblVolver2_MouseHover(object sender, EventArgs e)
        {
            lblVolver2.BackColor = System.Drawing.Color.MediumPurple;
            lblVolver2.ForeColor = System.Drawing.Color.GhostWhite;

        }
         
        private void lblVolver2_MouseLeave(object sender, EventArgs e)
        {
            lblVolver2.BackColor = System.Drawing.SystemColors.ControlLight;
            lblVolver2.ForeColor = System.Drawing.Color.MediumPurple;

        }

        private void timerVolver2_Tick(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                lblVolver2.Enabled = true;
            }
            else
            {
                lblVolver2.Enabled = false;
            }
        }

        private void cbCrterio1_MouseClick(object sender, MouseEventArgs e)
        {
            RestaurarLabelsSeleccione();
        }

        private void RestaurarLabelsSeleccione()
        {
            lblSeleccione1.ForeColor = System.Drawing.SystemColors.ControlText;
            lblSeleccione2.ForeColor = System.Drawing.SystemColors.ControlText;
            lblSeleccione3.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void cbCrterio2_MouseClick(object sender, MouseEventArgs e)
        {
            RestaurarLabelsSeleccione();
        }

        private void cbCrterio3_MouseClick(object sender, MouseEventArgs e)
        {
            RestaurarLabelsSeleccione();
        }

        private void cbCrterio3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCrterio3_MouseClick_1(object sender, MouseEventArgs e)
        {
            RestaurarLabelsSeleccione();
        }

        private void checkRangoDePrecios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }

        }

        private void tbMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroConComa(e);
        }

        private void ValidarNumeroConComa(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void tbMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroConComa(e);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artinegocio = new ArticuloNegocio();
            try
            {
                artinegocio.InsertarArticulosIniciales();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artinegocio = new ArticuloNegocio();
            try
            {
                artinegocio.EliminarTodosLosArticulos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
