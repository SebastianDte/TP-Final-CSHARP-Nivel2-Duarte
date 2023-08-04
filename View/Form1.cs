using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace View
{
    public partial class Form1 : Form
    {
        public List<Articulo> listaArticulo;
        private articuloNegocio articulosNegocio = new articuloNegocio();
        private HelpersVistas helpers = new HelpersVistas();
        
        public Form1()
        {
            InitializeComponent();
            customizarDiseño();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private void customizarDiseño()
        {
            
            pnlBuscar.Visible = false;
            pnllAdmArticulos.Visible = false;
            txtFiltrar.Visible = false;
            pnlAvanzada.Visible = false;
            pnlAyuda.Visible = false;
        }
        private void ocultarSubMenu()
        {
            
            if (pnllAdmArticulos.Visible == true)
                pnllAdmArticulos.Visible = false;
            if(pnlBuscar.Visible == true)
                pnlBuscar.Visible = false;
            if (txtFiltrar.Visible == true)
                txtFiltrar.Visible = false;
            if (pnlAyuda.Visible == true)
                pnlAyuda.Visible = false;
        }
        private void mostrarTexto(TextBox subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else 
            {
                subMenu.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            helpers.Cargar(ref listaArticulo, dgvArticulos, pxbArticulo);
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    helpers.cargarImagen(seleccionado.urlImagen, pxbArticulo);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlta alta = new FrmAlta();
            alta.ShowDialog();
            helpers.Cargar(ref listaArticulo, dgvArticulos, pxbArticulo);

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    FrmAlta modificar = new FrmAlta(seleccionado);
                    modificar.ShowDialog();
                    helpers.Cargar(ref listaArticulo, dgvArticulos, pxbArticulo);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar, comunicate con atención al cliente");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.id);
                        helpers.Cargar(ref listaArticulo, dgvArticulos, pxbArticulo);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            List<Articulo> listaFiltrada;
            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaArticulo.FindAll(a => a.nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            helpers.ocultarColumnas(dgvArticulos);



        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else 
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (helpers.validarFiltro(cboCampo,cboCriterio,txtFiltroAvanzado))
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = articulosNegocio.filtrar(campo, criterio, filtro);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAdmArticulos_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnllAdmArticulos);

        }
        private void btnporNombre_Click(object sender, EventArgs e)
        {
            mostrarTexto(txtFiltrar);
           
        }
        private void btnSubBuscar_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlBuscar);
            pnlAvanzada.Visible = false;
        }
        private void btnAvanzada_Click_1(object sender, EventArgs e)
        {
            if (pnlAvanzada.Visible)
                pnlAvanzada.Visible = false;
            else
                pnlAvanzada.Visible = true;
        }
        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlAyuda);
        }

        private void btnnBuscar_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlBuscar);
            pnlAvanzada.Visible = false;
        }

        //boton AdmDeArticulos
        private void iconButton2_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnllAdmArticulos);

        }
        //Boton Ayuda
        private void iconButton3_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlAyuda);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        //Movimiento del panel

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
        
}
            
            
            
            






            
            

            
            
            
            
            
            
        

           
            
        


            
            
     


        



        




            

        

                

            







            



        
        
        






            


        

        



            
            
                
            

            
