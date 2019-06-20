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
        int contador = 1, lineapalabra;
        string Nombre_Archivo, direccion;
        Nimbus_BLL obj_Bll = new Nimbus_BLL();
        DateTime Hoy = DateTime.Now;
        int Ambito = 0, CAmbito = 0;

        public Form1()
        {
            InitializeComponent();

            //Codigo Agregado
            //Mensaje_carga_data();
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

            Button_Lexico.Visible = false;
            Button_Sintactico.Visible = false;
            Button_Semantico.Visible = false;

            Btn_Primero.Visible = true;
            Btn_Anterior.Visible = true;
            Btn_Siguiente.Visible = true;
            Btn_Ultimo.Visible = true;
            Btn_Buscar.Visible = true;
        }

        public void Activar()
        {
            tabControl1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;

            Button_Guardar.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            guardarComoToolStripMenuItem.Enabled = true;

            Button_Lexico.Visible = true;
            Button_Sintactico.Visible = true;
            Button_Semantico.Visible = false;
        }
        #endregion

        #region Metodos_Cargar_Tabla_Simbolos
        public void Mensaje_carga_data()
        {
            //MessageBox.Show("Cargue la tabla de Simbolos", "Nimbus 369", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //LoadData();
        }

        public void LoadData()
        {
            contador = 0;
            Nimbus_DAL objTmp = new Nimbus_DAL();
            try
            {
                //OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Title = "csv";
                //ofd.ShowDialog();
                //if (File.Exists(ofd.FileName))
                //{
                //    string[] Lines = File.ReadAllLines(ofd.FileName);
                //    foreach (var line in Lines)
                //    {
                //        var values = line.Split(',');
                //        objTmp.CODIGO = values[0];
                //        objTmp.SIMBOLO = values[1];
                //        objTmp.TIPO_TOKEN = values[2];
                //        obj_Bll.SAVE(objTmp.CODIGO, objTmp.SIMBOLO, objTmp.TIPO_TOKEN);
                //        contador++;
                //    }
                //}
                //ofd.Dispose();
                //MessageBox.Show("Lenguaje cargado.");
                /////////////////////////////////////////////////////////////////////////////////////////
                string[] Lines = File.ReadAllLines("C:\\Users\\dmx369zhw\\Documents\\GitHub\\Modelo_Programacion_Sistemas\\Tabla_Simbolos\\Tabla_Simbolos.csv"); 
                foreach (var line in Lines)
                {
                    var values = line.Split(',');
                    objTmp.CODIGO = values[0];
                    objTmp.SIMBOLO = values[1];
                    objTmp.TIPO_TOKEN = values[2];
                    objTmp.AMBITO = Convert.ToInt32(values[3]);
                    obj_Bll.SAVE(objTmp.CODIGO, objTmp.SIMBOLO, objTmp.TIPO_TOKEN, objTmp.AMBITO);
                    contador++;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en carga el Lenguaje");
                LoadData();
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

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
                dataGridView2.Rows.Clear();

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
                dataGridView2.Rows.Clear();
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
                        //Si existe el archivo
                        StreamWriter codigonuevo = File.CreateText(Salvar_Archivo.FileName);
                        codigonuevo.Write(Panel_Codigo.Text);
                        codigonuevo.Flush();
                        codigonuevo.Close();
                        Nombre_Archivo = Salvar_Archivo.FileName;
                        direccion = Salvar_Archivo.FileName;
                    }
                    else
                    {
                        //No existe el archivo
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

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Metodo_Colocar_Numero_Linea
        private void Panel_Codigo_VScroll(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = Panel_Codigo.GetPositionFromCharIndex(0).Y %
                                      (Panel_Codigo.Font.Height + 1);
            label1.Location = new Point(0, d);

            Lablel_ActualizarLinea();
        }

        private void Panel_Codigo_TextChanged(object sender, EventArgs e)
        {
            Lablel_ActualizarLinea();
        }

        private void Lablel_ActualizarLinea()
        {
            //Obtenemos índice del primer caracter visible y
            //número de la primera línea visible
            Point pos = new Point(0, 0);
            int firstIndex = Panel_Codigo.GetCharIndexFromPosition(pos);
            int firstLine = Panel_Codigo.GetLineFromCharIndex(firstIndex);

            //Ahora obtenemos el índice del último carácter visible y 
            //el número de la última línea visible.
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = Panel_Codigo.GetCharIndexFromPosition(pos);
            int lastLine = Panel_Codigo.GetLineFromCharIndex(lastIndex);

            //esta es la posición del punto del último carácter visible, 
            //usaremos su valor Y para calcular el tamaño de la etiqueta
            pos = Panel_Codigo.GetPositionFromCharIndex(lastIndex);

            //finalmente, se renumera etiqueta
            label1.Text = "";
            for (int i = firstLine; i <= lastLine; i++)
            {
                label1.Text += i + 1 + "\n";
            }

        }
        #endregion

        #region Metodo_limpiar
        public void Limpiar()
        {
            //Panel_Codigo.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
        #endregion

        #region Metodo_salir
        public void Salir()
        {
            if (MessageBox.Show("Desea Guardar las Tablas?", "Confirm User Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowcount1 = dataGridView1.Rows.Count;
                int rowcount2 = dataGridView1.Rows.Count;
                if (dataGridView1.Visible || dataGridView2.Visible)
                {
                    if (rowcount1 > 0 || rowcount2 > 0)
                    {
                        Salvar_tablas();
                    }
                }
                System.Windows.Forms.Application.Exit();

            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        #endregion

        #region Metodo_validar_Numero
        public bool ValidaEntero(String Variable)
        {
            try
            {
                Int32.Parse(Variable);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Metodo_SetInfo
        public void SetInfo(Nimbus_DAL objTmp)
        {
            try
            {
                dataGridView1.Rows.Add(objTmp.CODIGO, objTmp.SIMBOLO, objTmp.TIPO_TOKEN, objTmp.AMBITO);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en Token");
            }
        }
        #endregion

        #region Metodo_SetInfoError
        public void SetInfoError(Nimbus_DAL objTmp, string Error, int lineapalabra)
        {
            try
            {
                string error = "Error Lexico, Id del Token: " + objTmp.CODIGO + ", Token: " + objTmp.SIMBOLO + ", Ambito: " + objTmp.AMBITO
                    + ", Error: " + Error + ", Posición: " + lineapalabra;
                dataGridView2.Rows.Add(error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en Token");
            }
        }
        #endregion

        #region Metodo_Guardar_tabla_Simbolos_Tabla_Errores
        public void Salvar_tablas()
        {
            Guardar_tabla_Simbolos();
            Guardar_tabla_Errores();
            MessageBox.Show("Datos Exportados a C:\\Nimbus");
        }
        public void Guardar_tabla_Simbolos()
        {
            if (!Directory.Exists(@"C:\Nimbus\Tabla_Simbolos"))
            {
                Directory.CreateDirectory(@"C:\Nimbus\Tabla_Simbolos");
            }

            TextWriter TSimbolos = new StreamWriter(@"C:\Nimbus\Tabla_Simbolos\Tabla_Simbolos_" + Hoy.Month + Hoy.Day + Hoy.Year + "_" + Hoy.Hour + Hoy.Minute + Hoy.Second + ".txt");
            int rowcount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                TSimbolos.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t"
                                + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t"
                                + dataGridView1.Rows[i].Cells[2].Value.ToString() + "\t"
                                + dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t");
            }
            TSimbolos.Close();

        }

        public void Guardar_tabla_Errores()
        {
            if (!Directory.Exists(@"C:\Nimbus\Tabla_Errores"))
            {
                Directory.CreateDirectory(@"C:\Nimbus\Tabla_Errores");
            }

            TextWriter TErrores = new StreamWriter(@"C:\Nimbus\Tabla_Errores\Tabla_Errores_" + Hoy.Month + Hoy.Day + Hoy.Year + "_" + Hoy.Hour + Hoy.Minute + Hoy.Second + ".txt");
            int rowcount = dataGridView2.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                TErrores.WriteLine(dataGridView2.Rows[i].Cells[0].Value.ToString() + "\t");
            }
            TErrores.Close();
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Analisis_Lexico
        public void Lexico()
        {
            Ambito = 0;
            LoadData();

            Nimbus_DAL obj_Dal = new Nimbus_DAL();
            Nimbus_DAL obj_temp = new Nimbus_DAL();
            string Simbol = "hh", Token = "jj";
            char[] delimitador = {' ', '\n'}; //   \udddd \xA


            string Frase = Panel_Codigo.Text;
            //MessageBox.Show(Frase);
            string[] Palabras = Frase.Split(delimitador);
            
            foreach (var palabra in Palabras)
            {
                lineapalabra = Panel_Codigo.Find(palabra);
                obj_Dal.SIMBOLO = palabra.Trim();
                Token = palabra.Trim();

                obj_temp = obj_Bll.SEARCH_TOKEN(obj_Dal);
                Simbol = obj_temp.SIMBOLO;

                #region Control de Ambito
                if (Token.Equals("["))
                {
                    Ambito = Ambito + 1;
                    //CAmbito = CAmbito + 1;
                }          
                if (Token.Equals("]"))
                {
                   Ambito = Ambito - 1;
                }
                #endregion

                if (Simbol == string.Empty || Simbol == null)
                {
                    if (Token != string.Empty || Token != null)
                    {
                        bool vacio = true;
                        char[] letras = Token.ToCharArray();

                        foreach (var letra in letras)
                        {
                            if (!letra.Equals(" "))
                            {
                                if (char.IsNumber(letra))
                                {
                                    if (ValidaEntero(Token))
                                    {
                                        obj_Dal.TIPO_TOKEN = "Digito_Entero";
                                    }
                                    else
                                    {
                                        obj_Dal.TIPO_TOKEN = "Digito_Flotante";
                                    }
                                }
                                else if (char.IsPunctuation(letra))
                                {
                                    obj_Dal.TIPO_TOKEN = "Caracter";
                                }
                                else
                                {
                                    obj_Dal.TIPO_TOKEN = "Variable";
                                }
                                vacio = false;
                            }
                            
                        }
                        if(vacio == false)
                        {
                            obj_Dal.CODIGO = Convert.ToString(contador);
                            obj_Dal.SIMBOLO = Token;
                            obj_Dal.AMBITO = Ambito;
                            obj_Bll.SAVE(obj_Dal.CODIGO, obj_Dal.SIMBOLO, obj_Dal.TIPO_TOKEN, obj_Dal.AMBITO);
                            SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));
                            contador = contador + 1;
                        }
                        
                    }
                }
                else
                {
                    if (obj_temp.TIPO_TOKEN.Equals("Inicio_de_Programa") || obj_temp.TIPO_TOKEN.Equals("Funcion_Principal") ||
                    obj_temp.TIPO_TOKEN.Equals("Apertura_Ambito") || obj_temp.TIPO_TOKEN.Equals("Cierre_Ambito") ||
                    obj_temp.TIPO_TOKEN.Equals("Signo_de_Puntuacion") || obj_temp.TIPO_TOKEN.Equals("Constante") ||
                    obj_temp.TIPO_TOKEN.Equals("Concatenacion") || obj_temp.TIPO_TOKEN.Equals("Asignacion") || 
                    obj_temp.TIPO_TOKEN.Equals("Encapsulamiento") || obj_temp.TIPO_TOKEN.Equals("Palabra_Reservada") ||
                    obj_temp.TIPO_TOKEN.Equals("Funcion_Imprimir") || obj_temp.TIPO_TOKEN.Equals("Funcion_Capturar") ||
                    obj_temp.TIPO_TOKEN.Equals("Operador_Matematico") || obj_temp.TIPO_TOKEN.Equals("Expresion_Booleana") || 
                    obj_temp.TIPO_TOKEN.Equals("Operador_Logico") || obj_temp.TIPO_TOKEN.Equals("Condicional") ||
                    obj_temp.TIPO_TOKEN.Equals("Ciclo") || obj_temp.TIPO_TOKEN.Equals("Declarador_de_Funcion") ||
                    obj_temp.TIPO_TOKEN.Equals("Retorno_Funcion") || obj_temp.TIPO_TOKEN.Equals("Declarador_de_Procedimiento") ||
                    obj_temp.TIPO_TOKEN.Equals("Delimitador_de_Sentencia") || obj_temp.TIPO_TOKEN.Equals("Digito_Entero") ||
                    obj_temp.TIPO_TOKEN.Equals("Digito_Flotante"))
                    {
                        obj_temp.AMBITO = Ambito;
                        obj_Bll.MODIFICAR(obj_temp);
                        SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));

                    }
                    else
                    {
                        if (obj_temp.AMBITO == Ambito)
                        {
                            string error = "Variable ya existente";
                            SetInfoError(obj_Bll.SEARCH_TOKEN(obj_Dal), error, lineapalabra);
                        }
                        else
                        {
                            obj_temp.AMBITO = Ambito;
                            obj_Bll.MODIFICAR(obj_temp);
                            SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal));
                        }
                    }
                }
            }

            if (Ambito != 0)
            {
                string error = "Fata cierre de Ambito";
                SetInfoError(obj_Bll.SEARCH_TOKEN(obj_Dal), error, lineapalabra);
            }
            obj_Bll.DELETE_LIST();
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

        #region Analisis_Sintactico
        public void Sintactico()
        {
            Nimbus_DAL obj_Dal = new Nimbus_DAL();
            Nimbus_DAL obj_temp = new Nimbus_DAL();
            char[] delimitador = {'\udddd', '\xA' }; //   \udddd \xA

            string Frase = Panel_Codigo.Text;
            string[] Palabras = Frase.Split(delimitador);

            foreach (var palabra in Palabras)
            {
                Patrones Patron = new Patrones();
                //MessageBox.Show(palabra);

                if (!Patrones.VALIDA_CONTEXTO(palabra))
                {
                    string error = "Error Sintactico, Definición: " + palabra + ", Error en definicion sintactica,  " + "Posición: " + lineapalabra;
                    dataGridView2.Rows.Add(error);
                }
                //else
                //{
                //    string error = palabra + " correcto";
                //    dataGridView2.Rows.Add(error);
                //}
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////

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
            Salir();
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
            Salir();
        }
        #endregion

        #region Botones_desplazamiento y busqueda
        private void Btn_Primero_Click(object sender, EventArgs e)
        {
            //SetInfo(obj_Bll.FIRST(), lineapalabra);
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            //SetInfo(obj_Bll.PREVIOUS(), lineapalabra);
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            //SetInfo(obj_Bll.FOLLOWING(), lineapalabra);
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            //SetInfo(obj_Bll.LAST(), lineapalabra);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Nimbus_DAL obj_Dal = new Nimbus_DAL();
            obj_Dal.SIMBOLO = TextBox_Search.Text.Trim();
            //SetInfo(obj_Bll.SEARCH_TOKEN(obj_Dal), lineapalabra);
        }
        #endregion

        #region Boton_Limpiar
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Botones_Lexico_Sintactico_Semantico
        private void Button_Lexico_Click(object sender, EventArgs e)
        {
            Limpiar();
            Lexico();
        }

        private void Button_Sintactico_Click(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Clear();
            //Limpiar();
            Sintactico();
        }

        private void Button_Semantico_Click(object sender, EventArgs e)
        {

        }
        #endregion

        


    }
}
