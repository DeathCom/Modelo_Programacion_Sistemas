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

namespace Nimbus_01P
{
    public partial class Form1 : Form
    {
        int cantLineas = 0;
        string Nombre_Archivo, direccion;

        public Form1()
        {
            InitializeComponent();

            //Codigo Agregado
            tabControl1.Visible = false;
        }

        #region Metodo_Leer_Archivo
        public void Leer_archivo(string NombreArchivo)
        {
            try
            {
                StreamReader Leer = new StreamReader(NombreArchivo, System.Text.Encoding.Default);
                string texto;
                texto = Leer.ReadToEnd();
                Leer.Close();
                Panel_Codigo.Text = texto;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede leer el archivo Correctamente, o el archivo esta danado");
            }

        }
        #endregion

        #region Metodos_Guardar_GuardaComo_Abrir_Nuevo
        public void Abrir_archivo()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Nimbus_369";
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                {
                    using (Stream cadena = ofd.OpenFile())
                    {
                        Leer_archivo(ofd.FileName);
                        Nombre_Archivo = ofd.FileName;
                        direccion = ofd.FileName;
                        tabControl1.Visible = true;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no se abrio correctamente");
            }

        }

        public void Guardar_Archivo_Como()
        {
            try
            {
                SaveFileDialog Salvar_Archivo = new SaveFileDialog();
                Salvar_Archivo.Filter = "Archivos n369|*.n369";
                if (Salvar_Archivo.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(Salvar_Archivo.FileName))
                    {
                        //Archivo Si existe
                        StreamWriter codigonuevo = File.CreateText(Salvar_Archivo.FileName);
                        codigonuevo.Write(Panel_Codigo.Text);
                        codigonuevo.Flush();
                        codigonuevo.Close();
                        Nombre_Archivo = Salvar_Archivo.FileName;
                        direccion = Salvar_Archivo.FileName;
                    }
                    else
                    {
                        //Archivo no existe
                        StreamWriter codigonuevo = File.CreateText(Salvar_Archivo.FileName);
                        codigonuevo.Write(Panel_Codigo.Text);
                        codigonuevo.Flush();
                        codigonuevo.Close();
                        Nombre_Archivo = Salvar_Archivo.FileName;
                        direccion = Salvar_Archivo.FileName;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar archivo");
            }
        }

        public void Archivo_Nuevo()
        {
            try
            {
                tabControl1.Visible = true;
                Panel_Codigo.Clear();
                Panel_Codigo.Text = "< !_Nimbus_369_Code_!> \n { \n\t # Nimbus_Main#() \n\t [ \n\n\t ] \n }";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear archivo");
            }
        }

        public void Guardar_Archivo()
        {
            try
            {
                if (Nombre_Archivo == null)
                {
                    Guardar_Archivo_Como();

                }
                else
                {
                    // el archivo nuevo
                    StreamWriter codigonuevo = File.CreateText(Nombre_Archivo);
                    codigonuevo.Write(Panel_Codigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar archivo");
            }

        }
        #endregion

        #region ToolStrip_Menu_Principal
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_archivo();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo_Nuevo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar_Archivo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar_Archivo_Como();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region Botones_Abrir_Salir_Guardar_Nuevo
        private void Button_Abrir_Click(object sender, EventArgs e)
        {
            Abrir_archivo();
        }

        private void Button_Nuevo_Click(object sender, EventArgs e)
        {
            Archivo_Nuevo();
        }

        private void Button_Guardar_Click(object sender, EventArgs e)
        {
            Guardar_Archivo();
        }

        private void Button_Salir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion
    }
}
