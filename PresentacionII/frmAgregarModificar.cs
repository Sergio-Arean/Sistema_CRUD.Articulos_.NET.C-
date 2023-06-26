using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PresentacionII
{
    public partial class frmAgregarModificar : Form
    {
        private Articulo arti = null;
        private int posY = 0;
        private int posX = 0;


        public frmAgregarModificar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor al que se invoca cuando se desea modificar el articulo seleccionado.
        /// </summary>
        /// <param name="arti"></param>
        public frmAgregarModificar(Articulo arti)
        {
            InitializeComponent();
            this.arti = arti;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            bool codigo_repetido = false;
            try
            {
                if (ValidarCamposCompletos()) 
                {
                    //divisoria de aguas entre agregar y modificar
                    if (arti == null) //estoy agregando
                    {
                        if (articuloNegocio.ValidarArticuloRepetido(tbCodigo.Text) == 0)
                        {
                            arti = new Articulo();
                            CargarArticulo(); //carga de arti, que estaba en null
                            articuloNegocio.AgregarArticulo(arti); //insercion en BBDD propiamente dicha
                            MessageBox.Show("El artículo ha sido agregado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            codigo_repetido = true;
                            MessageBox.Show("El código ingresado ya se encuentra presente en el Catálogo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else //estoy modificando
                    {
                        if (articuloNegocio.ValidarArticuloRepetido(tbCodigo.Text,arti) == 0)
                        {
                            CargarArticulo(); //sobreescribo datos
                            articuloNegocio.ModificarArticulo(arti);
                            MessageBox.Show("El artículo ha sido modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            codigo_repetido = true;
                            MessageBox.Show("El código ingresado ya se encuentra presente en el Catálogo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }

                    if (!codigo_repetido)
                        Close();





                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private bool ValidarCamposCompletos()
        {
            bool respuesta = true;
            Color color_designado = System.Drawing.Color.LightPink;
            if(tbCodigo.Text== "Ingrese Código")
            {
                CambiarColorTextoTextBox(tbCodigo, color_designado);
                respuesta = false;
            }
            if(tbNombre.Text== "Ingrese Nombre")
            {
                CambiarColorTextoTextBox(tbNombre, color_designado);
                respuesta = false;
            }
            if(tbDescripcion.Text== "Ingrese Descripción")
            {
                CambiarColorTextoTextBox(tbDescripcion, color_designado);
                respuesta = false;
            }
            if(tbUrlImagen.Text== "Ingrese URL")
            {
                CambiarColorTextoTextBox(tbUrlImagen, color_designado);
                respuesta = false;
            }
            if(tbPrecio.Text== "Ingrese Precio")
            {
                CambiarColorTextoTextBox(tbPrecio, color_designado);
                respuesta = false;
            }
            return respuesta;
        }

        private void CambiarColorTextoTextBox(TextBox tb, Color color) 
        {
            tb.ForeColor = color;
        }

        private void CargarArticulo()
        {
            
            try
             {
                     arti.Codigo = tbCodigo.Text;
                     arti.Nombre = tbNombre.Text;
                     arti.Descripcion = tbDescripcion.Text;
                     arti.Marca = (Marca)cbMarca.SelectedItem; 
                     arti.Categoria = (Categoria) cbCategoria.SelectedItem; 
                     arti.ImagenUrl = tbUrlImagen.Text;
                     arti.Precio = decimal.Parse(tbPrecio.Text);

             }
             catch (Exception ex)
             {

                 throw ex;
             }
        }

        private void frmAgregarModificar_Load(object sender, EventArgs e)
        {
            
            CargarComboBox();
            if (arti != null) // si estamos modificando
            {
                CargarImagen(arti.ImagenUrl);
                CargarCampos();
                FormatoCamposOcupados();
                
            }
            else //si estoy agregando uno nuevo
            {
                CargarImagenInicial();
                cbMarca.SelectedIndex = -1;
                cbCategoria.SelectedIndex = -1;
            }
            ReducirOpacidad();
        }
        /// <summary>
        /// Reduce la opacidad del color del formulario
        /// </summary>
        private void ReducirOpacidad()
        {
            Color color_actual = panelTotal.BackColor;
            //  (0-255, donde 0 es totalmente transparente y 255 es opaco)
            int nuevo_valor_alfa = 0;
            Color nuevoColor = Color.FromArgb(nuevo_valor_alfa, color_actual.R, color_actual.G, color_actual.B);
            panelTotal.BackColor = nuevoColor;
        }


        private void FormatoCamposOcupados()
        {
            tbCodigo.ForeColor = System.Drawing.Color.White;
            tbNombre.ForeColor = System.Drawing.Color.White;
            tbDescripcion.ForeColor = System.Drawing.Color.White;
            tbUrlImagen.ForeColor = System.Drawing.Color.White;
            tbPrecio.ForeColor = System.Drawing.Color.White;

        }

        private void CargarCampos()
        {
           
            
            Text = "Modificar Artículo";
            tbCodigo.Text = arti.Codigo;
            tbNombre.Text = arti.Nombre;
            tbDescripcion.Text = arti.Descripcion;
            tbUrlImagen.Text = arti.ImagenUrl;
            tbPrecio.Text = arti.Precio.ToString();
        }

        private void CargarComboBox()
        {
            //este metodo lista categorias y marcas en los respectivos combobox,
            //ademas setea que ninguna opcion este seleccionada
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbCategoria.DataSource = categoriaNegocio.listarCategorias();


            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbMarca.DataSource =  marcaNegocio.listarMarcas();


            //seteo de clave y valor
            /*cbCategoria.ValueMember= "Id";
            cbCategoria.DisplayMember = "Descripcion";

            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";*/

            






        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Metodos de seteo de picture box e icon picture box
        private void VisibilidadImagenEmoji(bool v)
        {
            //con este metodo seteamos la relacion de visibilidad entre el emoji y la imagen del articulo
            //ya que ambos son opuestos... cuando uno aparece el otro debe estar invisible y viceversa
            if (v)
            {
                //lblVolver.Visible = false;
                pbArticulo.Visible = true;
                IPBArticulo.Visible = false;

            }
            else
            {
                pbArticulo.Visible = false;
                IPBArticulo.Visible = true;
            }
        }

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

        private void CargarImagenInicial()
        {
            VisibilidadImagenEmoji(false);
            IPBArticulo.IconChar = FontAwesome.Sharp.IconChar.Image;
        }



        private void VaciarTextBox(TextBox v)
        {
            if (arti==null)
            {
                v.Text = "";
            }
            
        }

        private void tbCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            tbCodigo.ForeColor = System.Drawing.Color.White;
            if (tbCodigo.Text == "Ingrese Código")
                VaciarTextBox(tbCodigo);
            
        }

        private void tbNombre_MouseClick(object sender, MouseEventArgs e)
        {
            tbNombre.ForeColor = System.Drawing.Color.White;
            if (tbNombre.Text == "Ingrese Nombre")
                VaciarTextBox(tbNombre);
        }

        private void tbDescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            tbDescripcion.ForeColor = System.Drawing.Color.White;
            if (tbDescripcion.Text == "Ingrese Descripción")
                VaciarTextBox(tbDescripcion);
        }

        private void tbUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUrlImagen_MouseClick(object sender, MouseEventArgs e)
        {
            tbUrlImagen.ForeColor = System.Drawing.Color.White;
            if (tbUrlImagen.Text == "Ingrese URL") 
                VaciarTextBox(tbUrlImagen);
        }

        private void tbPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            tbPrecio.ForeColor = System.Drawing.Color.White;
            if (tbPrecio.Text == "Ingrese Precio")
                VaciarTextBox(tbPrecio);
        }

        private void panelTotal_MouseMove(object sender, MouseEventArgs e)
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

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                tbCodigo.ForeColor = System.Drawing.Color.LightGray;
                tbCodigo.Text = "Ingrese Código";

            }
            
            
                AlinearTexto(tbCodigo); 
           
            
        }

        private void AlinearTexto(TextBox tb)
        {
            /**este metodo alinea el texto de un textbox recibido por parametro**/
            /*
            string cadena = "";
            cadena = tb.Text;
            tb.TextAlign = HorizontalAlignment.Left;
            tb.Text = cadena;*/
            tb.Select(0, 0);

        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                tbNombre.ForeColor = System.Drawing.Color.LightGray;
                tbNombre.Text = "Ingrese Nombre";
            }

            AlinearTexto(tbNombre);
        }

        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                tbDescripcion.ForeColor = System.Drawing.Color.LightGray;
                tbDescripcion.Text = "Ingrese Descripción";
            }
            AlinearTexto(tbDescripcion);
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUrlImagen.Text))
            {
                tbUrlImagen.ForeColor = System.Drawing.Color.LightGray;
                tbUrlImagen.Text = "Ingrese URL";
            }
            else //si no esta vacio
            {
                CargarImagen(tbUrlImagen.Text);
            }
            AlinearTexto(tbUrlImagen);
        }

        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrecio.Text))
            {
                tbPrecio.ForeColor = System.Drawing.Color.LightGray;
                tbPrecio.Text = "Ingrese Precio";
            }
            AlinearTexto(tbPrecio);
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {


            string ruta_carpeta = Path.Combine("C:\\", "Catalogo de Articulos - Imagenes");
            string nombre_archivo;
            DateTime fecha_actual;
            string cadena_fecha_actual;
            string path_destino;



            try
            {
                OpenFileDialog archivo = new OpenFileDialog();
                archivo.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    CargarImagen(archivo.FileName);

                    tbUrlImagen.Text = archivo.FileName;

                    //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + archivo.SafeFileName);
                    
                    fecha_actual = DateTime.Now;

                    cadena_fecha_actual = fecha_actual.ToString("yyyy-MM-dd HH.mm.ss");

                    Directory.CreateDirectory(ruta_carpeta);

                    path_destino = ConfigurationManager.AppSettings["carpeta-creada"] + cadena_fecha_actual + archivo.SafeFileName;

                    File.Copy(archivo.FileName, path_destino);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
 
        }

        private void panelTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroConComa(e);
            CambiarColorAlPresionarTecla(tbPrecio);

        }

        private void ValidarNumeroConComa(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambiarColorAlPresionarTecla(tbCodigo);
        }

        private void CambiarColorAlPresionarTecla(TextBox tb)
        {
            tb.ForeColor = System.Drawing.Color.White;
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambiarColorAlPresionarTecla(tbNombre);
        }

        private void tbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambiarColorAlPresionarTecla(tbDescripcion);
        }

        private void tbUrlImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            CambiarColorAlPresionarTecla(tbUrlImagen);
        }

        private void tbCodigo_Enter(object sender, EventArgs e)
        {
            //DesactivarSeleccionTextoTb(tbCodigo);
        }

        private void DesactivarSeleccionTextoTb(TextBox tb) // no anda :(
        {
            tb.Focus();
            tb.SelectionLength = 0;
        }
    }
}
