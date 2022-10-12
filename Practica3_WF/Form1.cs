using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica3_WF
{
    public partial class Form1 : Form
    {
        List<string> cadena = new List<string>();

        // Código y mensaje de error
        public static int codError { get; set; }
        public static string MsgError { get; set; }

        public static List<string> codOG { get; set; }
        public static int indexCod { get; set; }

        Analisis ans = new Analisis();

        public Form1()
        {
            InitializeComponent();
            indexCod = -1; // Default combobox de código
            codOG = new List<string>(); // Codigo default
            codOG.AddRange(txtCadena.Lines);
            cadena = codOG;
        }

        int m, mx, my;

        private void cboPredet_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCadena.Clear();
            Limpiar();
            switch (cboPredet.SelectedIndex)
            {
                case 0:
                    LlenarTexto(EjemplosCodigo.IngresarNum());
                    break;
                case 1:
                    LlenarTexto(EjemplosCodigo.SumarDosNum());
                    break;
                case 2:
                    LlenarTexto(EjemplosCodigo.RestarUno());
                    break;
                default:
                    break;
            }
            indexCod = cboPredet.SelectedIndex;
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            Limpiar();

            // Guardar txtbox en Lista cadena
            cadena.AddRange(txtCadena.Lines);

            // Si el análisis no sale bien, mostrar error
            // Debe seguir este orden
            if (ans.Lexico(cadena) != true || ans.Semantico(cadena) != true || ans.Logico(cadena) != true || ans.puntocoma(cadena) != true || ans.Reservadas(cadena) != true)
            {
                MostrarError();
            }
            else
            {
                txtError.BackColor = Color.Green;
                txtMsgError.Text = "No se detectaron errores";
            }
        }

        private void LlenarTexto(List<string> codigo)
        {
            for (int i = 0; i < codigo.Count; i++)
            {
                txtCadena.AppendText(codigo[i]);
                if (i != codigo.Count - 1)
                {
                    txtCadena.AppendText(Environment.NewLine);
                }
            }
            codOG = codigo;
        }

        public void MostrarError()
        {
            txtError.Clear();
            txtMsgError.Clear();
            switch (codError)
            {
                case 0:
                    txtError.Text = "Error Léxico";
                    break;
                case 1:
                    txtError.Text = "Error Sintáctico";
                    break;
                case 2:
                    txtError.Text = "Error Semántico";
                    break;
                case 3:
                    txtError.Text = "Error Lógico";
                    break;
                default:
                    txtError.Text = "ERROR, codError no especificado";
                    break;
            }
            txtMsgError.AppendText(MsgError);
            txtError.BackColor = Color.Red;
            txtError.ForeColor = Color.White;
        }

        private void Limpiar()
        {
            MsgError = null;
            codError = -1;
            txtMsgError.Text = "";
            txtError.Text = "";
            txtError.BackColor = DefaultBackColor;
            txtError.ForeColor = DefaultForeColor;

            cadena = new List<string>();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }

    public class Analisis
    {
        //léxico, sintáctico, semántico y lógico (0,1,2,3)
        public Dictionary<int, List<string>> reservadas;
        public List<char> caract_inval;
        public Analisis()
        {
            reservadas = new Dictionary<int, List<string>>();
            reservadas.Add(-1, new List<string> { "string" });
            reservadas.Add(0, new List<string> { "Console", "Write", "int", "int", "Parse", "ReadLine", "Write" });
            reservadas.Add(1, new List<string> { "string", "int", "int", "int" ,"Parse" });
            reservadas.Add(2, new List<string> { "int" });
 
            // Alt + 0 - 31? 
            caract_inval = new List<char>{'☺', '☻', '◙', '♂', '♀', '♪','♫',
                                          '☼','►','◄', '↕', '‼', '¶','§','▬',
                                          '↨','°', '↓', '→', '←', '↑', '☻', '♥',
                                          '♠', '♣', '♦', '•', '◘', '○', '⌂' };
        }
        
        // Identificar ; en el código
        public bool puntocoma(List<string> cadena)
        {
            // Se lee cada linea de la cadena
            for (int i = 0; i < cadena.Count; i++)
            {
                // Si la linea no está vacía, si el último caracter de la cadena no es ';',
                // y si el primer caracter no es un espacio en blanco o separador...
                if (cadena[i] != "" && !cadena[i].Last().Equals(';') && !char.IsWhiteSpace(cadena[i].FirstOrDefault()) && !char.IsSeparator(cadena[i].FirstOrDefault()))
                {
                    Form1.MsgError = "Falta ; al final de la línea " + (i + 1);
                    Form1.codError = 1;
                    return false;
                }
            }
            return true; // No hay error
        }

        // Busqueda de palabras reservadas faltantes
        public bool Reservadas(List<string> cadena)
        {
            for (int i = 0; i < cadena.Count; i++)
            {
                // Si el código original no coincide con el nuevo...
                if (Form1.codOG[i] != cadena[i])
                {
                    // Para cada palabra reservada...
                    for (int j = 0; j < reservadas[Form1.indexCod].Count(); j++)
                    {
                        // Comparar en busca de una palabra reservada faltante...
                        if (!cadena[i].Contains(reservadas[Form1.indexCod][j]))
                        {
                            int temp_index = cadena[i].IndexOf(reservadas[Form1.indexCod][j]);
                            Form1.MsgError = "Error en palabra reservada, línea " + (i + 1);
                            Form1.codError = 1;
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        // Para detectar estos errores, se tienen que buscar específicamente
        public bool Logico(List<string> cadena)
        {
            // A la medida paracada caso
            switch (Form1.indexCod)
            {
                // No hay error lógico, solo sintáctico de un operador (se puede omitir)
                case -1:
                    if (!cadena[0][14].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 1";
                        Form1.codError = 1;
                        return false;
                    }
                    break;
                // No hay error lógico, solo sintáctico de un operador (se puede omitir)
                case 0:
                    if (!cadena[1][8].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 1";
                        Form1.codError = 1;
                        return false;
                    }
                    break;
                // Error lógico
                case 1:
                    if (!cadena[0][12].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 1";
                        Form1.codError = 1;
                        return false;
                    }
                    if (!cadena[1][9].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 2";
                        Form1.codError = 1;
                        return false;
                    }
                    if (!cadena[3][14].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 2";
                        Form1.codError = 1;
                        return false;
                    }
                    if (!cadena[3][32].Equals('+'))
                    {
                        Form1.MsgError = "Se habla de sumar dos números, " +
                                         "pero se realizó otra acción, línea 2";
                        Form1.codError = 3;
                        return false;
                    }
                    break;
                // Error lógico
                case 2:
                    if (!cadena[0][11].Equals('='))
                    {
                        Form1.MsgError = "Operador erróneo o faltante, línea 1";
                        Form1.codError = 1;
                        return false;
                    }
                    if (!(cadena[1][6].Equals('-') && cadena[1][7].Equals('-')))
                    {
                        Form1.MsgError = "Se habla de decrementar en 1, " +
                                         "pero se realizó otra acción, línea 2";
                        Form1.codError = 3;
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool Semantico(List<string> cadena)
        {
            // A la medida para cada caso
            switch (Form1.indexCod)
            {
                case -1:
                    if (cadena[0].Substring(0, 6) != "string")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 1";
                        Form1.codError = 2;
                        return false;
                    }
                    break;
                
                case 0:
                    if (cadena[1].Substring(0, 3) == "num")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 2";
                        Form1.codError = 2;
                        return false;
                    }
                    if (cadena[1].Substring(0, 3) != "int")
                    {
                        Form1.MsgError = "Conversión de tipo de dato no permitida, línea 2";
                        Form1.codError = 2;
                        return false;
                    }
                    break;
                
                case 1:
                    if (cadena[0].Substring(0, 6) != "string")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 1";
                        Form1.codError = 2;
                        return false;
                    }
                    if (cadena[1].Substring(0, 3) != "int")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 2";
                        Form1.codError = 2;
                        return false;
                    }
                    if (cadena[3].Substring(0, 3) != "int")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 4";
                        Form1.codError = 2;
                        return false;
                    }
                    break;
                case 2:
                    if (cadena[0].Substring(0, 3) != "int")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 1";
                        Form1.codError = 2;
                        return false;
                    }
                    if (cadena[1].Substring(0, 6) != "numero")
                    {
                        Form1.MsgError = "Variable usada, pero no declarada, línea 1";
                        Form1.codError = 2;
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true;
        }

        public bool Lexico(List<string> cadena)
        {
            for (int i = 0; i < cadena.Count; i++)
            {
                for (int j = 0; j < cadena[i].Count(); j++)
                {
                    foreach (var item in caract_inval)
                    {
                        if (cadena[i][j].Equals(item))
                        {
                            Form1.MsgError = "Caracter inesperado. El símbolo no pertenece " +
                                             "al lenguaje de programación. Linea " + (i + 1);
                            Form1.codError = 0;
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }

    public static class EjemplosCodigo
    {
        static readonly string ruta = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))
                                      + "\\Codigo Ejemplo\\";

        // Ingresar numero
        public static List<string> IngresarNum()
        {
            List<string> texto = new List<string>();
            
            string temp_ruta = ruta;
            temp_ruta += "Ingreso.txt";
            StreamReader sr = new StreamReader(temp_ruta);
            while (sr.EndOfStream != true)
            {
                texto.Add(sr.ReadLine());
            }
            return texto;

        }

        // Suma de dos números
        public static List<string> SumarDosNum()
        {
            List<string> texto = new List<string>();

            string temp_ruta = ruta;
            temp_ruta += "Suma.txt";
            StreamReader sr = new StreamReader(temp_ruta);
            while (sr.EndOfStream != true)
            {
                texto.Add(sr.ReadLine());
            }
            return texto;
        }

        // Restar -1 a un número
        public static List<string> RestarUno()
        {
            List<string> texto = new List<string>();

            string temp_ruta = ruta;
            temp_ruta += "Resta.txt";
            StreamReader sr = new StreamReader(temp_ruta);
            while (sr.EndOfStream != true)
            {
                texto.Add(sr.ReadLine());
            }
            return texto;
        }

    }


}
