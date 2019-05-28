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
using Nimbus_02L;
using Nimbus_03D;


namespace Nimbus_01P
{
    public partial class Form1 : Form
    {
        int contador = 1;
        string Nombre_Archivo, direccion;
        Nimbus_BLL obj_Bll = new Nimbus_BLL();


        public Form1()
        {
            InitializeComponent();

            //Codigo Agregado
            Mensaje_carga_data();
            Desactivar();
        }

        #region Metodos_activar_Desactivar
        public void Desactivar()
        {
            tabControl1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            Button_Guardar.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            guardarComoToolStripMenuItem.Enabled = false;
        }

        public void Activar()
        {
            tabControl1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            Button_Guardar.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            guardarComoToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Cargar_Tabla_Simbolos
        public void Mensaje_carga_data()
        {
            //MessageBox.Show("Cargue la tabla de Simbolos", "Nimbus 369", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LoadData();
        }

        public void LoadData()
        {
            Nimbus_DAL objTmp = new Nimbus_DAL();
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "csv";
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                {
                    string[] Lines = File.ReadAllLines(ofd.FileName);
                    foreach (var line in Lines)
                    {
                        var values = line.Split(',');
                        objTmp.CODIGO = values[0];
                        objTmp.SIMBOLO = values[1];
                        objTmp.TIPO_TOKEN = values[2];
                        obj_Bll.SAVE(objTmp.CODIGO, objTmp.SIMBOLO, objTmp.TIPO_TOKEN);
                        contador++;
                    }
                }
                //MessageBox.Show("Lenguaje cargado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en carga e Lenguaje");
            }
        }
        #endregion

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
                Activar();
                dataGridView1.Rows.Clear();
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

        public void Archivo_Nuevo()
        {
            try
            {
                //tabControl1.Visible = true;
                Activar();
                Panel_Codigo.Clear();
                dataGridView1.Rows.Clear();
                Panel_Codigo.Text = "<!_Nimbus_369_Code_!> Nimbus_Main() [ ]";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear archivo");
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

        #region Botones_desplazamiento y busqueda
        private void Btn_Primero_Click(object sender, EventArgs e)
        {
            SetInfo(obj_Bll.FIRST());
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            SetInfo(obj_Bll.PREVIOUS());
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            SetInfo(obj_Bll.FOLLOWING());
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            SetInfo(obj_Bll.LAST());
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Nimbus_DAL obj_Dal = new Nimbus_DAL();
            obj_Dal.SIMBOLO = TextBox_Search.Text.Trim();
            SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));
        }
        #endregion

        #region Colocar_Info_Tabla_Simbolos
        public void SetInfo(Nimbus_DAL objTmp)
        {
            try
            {
                dataGridView1.Rows.Add(objTmp.CODIGO, objTmp.SIMBOLO, objTmp.TIPO_TOKEN);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en Token");
            }
        }

        
        #endregion

        #region Validar_Token_LLenar_Tabla_Token
        public void Validar_Tokens()
        {
            Nimbus_DAL obj_Dal = new Nimbus_DAL();
            Nimbus_DAL obj_temp = new Nimbus_DAL();
            string test = "hh", temp = "jj";

            string Frase = Panel_Codigo.Text;
            //MessageBox.Show(phrase);
            string[] Palabras = Frase.Split(' ', '\n');

            foreach (var palabra in Palabras)
            {
                //System.Console.WriteLine($"<{word}>");
                obj_Dal.SIMBOLO = palabra;
                temp = palabra;

                obj_temp = obj_Bll.SEARCH_TOKEN(obj_Dal);
                test = obj_temp.SIMBOLO;

                if (test == string.Empty || test == null)
                {
                    obj_Dal.CODIGO = Convert.ToString(contador);
                    obj_Dal.SIMBOLO = temp;
                    obj_Dal.TIPO_TOKEN = "Variable";
                    obj_Bll.SAVE(obj_Dal.CODIGO, obj_Dal.SIMBOLO, obj_Dal.TIPO_TOKEN);
                    SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));
                    contador = contador + 1;
                }
                else
                {
                    SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));
                }
            }
        }


        #endregion


        #region Botones_Lexico_Sintactico_Semantico
        private void Button_Lexico_Click(object sender, EventArgs e)
        {
            Validar_Tokens();
        }

        private void Button_Sintactico_Click(object sender, EventArgs e)
        {

        }

        private void Button_Semantico_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
