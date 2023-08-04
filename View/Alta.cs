using Dominio;
using Negocio;
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
using System.Configuration;


namespace View
{
    public partial class FrmAlta : Form
    {
        HelpersVistas helpers = new HelpersVistas();
        private Articulo articulo = null;
        public OpenFileDialog archivo { get; set; }
        public FrmAlta()
        {
            InitializeComponent();
           
        }
        public FrmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        public static bool ValidarCampos(List<TextBox> textBoxes, ErrorProvider errorProvider)
        {
            try
            {
                bool camposValidos = true;

                foreach (var textBox in textBoxes)
                {
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        errorProvider.SetError(textBox, "Este campo es obligatorio");
                        camposValidos = false;
                    }

                }

                return camposValidos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool ValidarPrecio(TextBox textBox,ErrorProvider errorProvider)
        {
            try
            {
                decimal precio;
                if (!decimal.TryParse(textBox.Text, out precio))
                {
                    errorProvider.SetError(textBox, "Ingrese un valor numérico válido para el precio");

                    return false;
                }
                else
                { return true; }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            errorAgregar.Clear();
            List<TextBox> textBoxes = new List<TextBox> { txtNombre, txtDescripcion, txtCodigo };
            try
            {
                    if(articulo == null)
                        articulo = new Articulo();
                if (ValidarCampos(textBoxes, errorAgregar) && ValidarPrecio(txtPrecio, errorAgregar))
                {
                    articulo.nombre = (txtNombre.Text);
                    articulo.descripcion = (txtDescripcion.Text);
                    articulo.codigo = (txtCodigo.Text);
                    articulo.precio = decimal.Parse((txtPrecio.Text));
                    articulo.urlImagen = (txtUrlImagen.Text);
                    articulo.marca = (Marca)cboMarca.SelectedItem;
                    articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                    if (articulo.id != 0)
                    {
                     
                        negocio.modificar(articulo);
                        helpers.guardarImagen(archivo, pxbAlta);
                        MessageBox.Show("Modificado Exitosamente");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        helpers.guardarImagen(archivo, pxbAlta);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    Close();
                }
                    
                else { MessageBox.Show("Por favor, complete todos los campos."); }
        }
            catch (Exception ex)
            { throw ex; }
        }
        private void FrmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio cbxCategoria = new CategoriaNegocio();
            MarcaNegocio cbxMarca = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = cbxCategoria.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";
                cboMarca.DataSource = cbxMarca.listar();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "descripcion";
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.codigo;
                    txtNombre.Text = articulo.nombre;
                    txtDescripcion.Text = articulo.descripcion;
                    txtUrlImagen.Text = articulo.urlImagen;
                    helpers.cargarImagen(articulo.urlImagen,pxbAlta);
                    txtPrecio.Text = articulo.precio.ToString();
                    cboCategoria.SelectedValue = articulo.categoria.id;
                    cboMarca.SelectedValue = articulo.marca.id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            helpers.cargarImagen(txtUrlImagen.Text,pxbAlta);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
             archivo = new OpenFileDialog();
            try
            {
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtUrlImagen.Text = archivo.FileName;
                    helpers.cargarImagen(archivo.FileName, pxbAlta);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            try
            {
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtUrlImagen.Text = archivo.FileName;
                    helpers.cargarImagen(archivo.FileName, pxbAlta);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
    

                        
                        
                    
                        
                        

                        
                    

                    
                    




                
                


                    
                
                        
                    
        
        

        
                    








               
                



                


