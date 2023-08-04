using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace View
{
    public class HelpersVistas
    {
        public void Cargar(ref List<Articulo>  lista, DataGridView data, PictureBox pxb)
        {
            articuloNegocio articulos = new articuloNegocio();
            try
            {
                lista = articulos.lista();
                data.DataSource = lista;
                ocultarColumnas(data);
                pxb.Load(lista[0].urlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ocultarColumnas(DataGridView data)
        {
            data.Columns ["UrlImagen"].Visible = false;
            data.Columns ["Id"].Visible = false;
        }
        public void cargarImagen(string imagen,PictureBox pictureBox)
        {
            try
            {
                pictureBox.Load(imagen);
            }
            catch (Exception)
            {
                pictureBox.Load("https://image.ondacero.es/clipping/cmsimages02/2021/09/20/B48108F9-45F3-417A-833D-259BC2CFA304/97.jpg?crop=2400,1350,x0,y0&width=1600&height=900&optimize=high&format=webply");
                
            }
        }
        public void guardarImagen(OpenFileDialog archivo,PictureBox picture)
        {
            try
            {
                
                if (archivo != null)
                {
                    string rutaDestino = Path.Combine(ConfigurationManager.AppSettings["Articulosimg"], archivo.SafeFileName);
                    if (File.Exists(rutaDestino))
                    {

                        DialogResult resultado = MessageBox.Show("Ya existe una imagen con el mismo nombre. ¿Desea reemplazarla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resultado == DialogResult.Yes)
                        {
                            
                            File.Delete(rutaDestino);
                            File.Copy(archivo.FileName, rutaDestino, true);
                        }
                    }
                    else
                    {
                        File.Copy(archivo.FileName, rutaDestino);
                    }
                }
            }
            catch (Exception)
            {
                cargarImagen(archivo.FileName, picture);
            }
            
        }
        public bool validarFiltro(ComboBox cboCampo,ComboBox cboCriterio,TextBox txtFiltroAvanzado)
        {
            if (cboCampo.SelectedItem != null && cboCriterio.SelectedItem != null)
            {
                if (cboCampo.SelectedItem.ToString() == "Precio")
                {
                    if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                    {
                        MessageBox.Show("Cargue el Precio");
                        return true;
                    }
                    if ((!soloNumeros(txtFiltroAvanzado.Text)))
                    {
                        MessageBox.Show("Esta en el campo de Precio, asegúrese de ingresar solo Números");
                        return true;
                    }

                }
                return false;
            }
            else
            {
                MessageBox.Show("Compruebe que Campo y Criterio esten seleccionados");
                return true;
            }
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                    return false;
            }
            return true;
        }
    }
}




                        
                            


            
      

           

           
        


        





        
