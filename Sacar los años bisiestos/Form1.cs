using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sacar_los_años_bisiestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AñoBisiesto()
        {
            int inicial, final;
            //Condiciones que validaran los TexBox con un mensaje 
            if (TextBox_Inicial.Text == "")
            {
                MessageBox.Show("Ingrese año inicial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox_Inicial.Focus();
            }
            else
            {
                //El valor que  ingrese por el textBox  con Convert.ToInt32 lo convertirá en tipo entero 
                inicial = Convert.ToInt32(TextBox_Inicial.Text);
                //Menor o Igual que
                if (inicial <= 3)
                {
                    MessageBox.Show("Año inicial debe tener 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBox_Inicial.Focus();
                }
                else
                {
                    //Condiciones que validaran los TexBox con un mensaje 
                    if (TextBox_Final.Text == "")
                    {
                        MessageBox.Show("Ingrese año final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBox_Final.Focus();
                    }
                    else
                    {
                        //El valor que  ingrese por el textBox  con Convert.ToInt32 lo convertirá en tipo entero 
                        final = Convert.ToInt32(TextBox_Final.Text);
                        //Menor o Igual que
                        if (final <= 3)
                        {
                            MessageBox.Show("Año final debe tener 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TextBox_Final.Focus();
                        }
                        else
                        {           //Mayor o Igual
                            if (inicial >= final)
                            {
                                MessageBox.Show("Año inicial debe ser menor que año final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //Clico for que nos permita repetir los valores que ingresemos por los TexBox
                                for (int inicio = inicial; inicio < final; inicio++)
                                //Menor
                                {
                                    /*Condición que nos permite mostrar los mensajes en el ListBox de acuerdo a la condición

                                           Esta condicion nos permitirá buscar los años bisiestos 
                                           ya que todos los años múltiplos de 4 son años Bisiestos  */

                                    //Cada 4 años si son bisiesto  cada 100 años no es bisiesto  Cada 400 años si son bisiesto  */
                                    if (inicio % 4 == 0 && (inicio % 100 != 0 || inicio % 400 == 0))
                                    //   Modulo    And          Distinto   o 
                                    {
                                        //Años múltiplos de 4 ,400 
                                        ListBox1.Items.Add("El año" + inicio.ToString() + " Si es bisiesto");
                                    }
                                    else
                                    {
                                        //Años no multiplos de 4 ,400
                                        ListBox1.Items.Add("El año" + inicio.ToString() + " No es bisiesto");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Button_Calcular_Click(object sender, EventArgs e)
        {
            AñoBisiesto();
        }

        private void Button_Limpiar_Click(object sender, EventArgs e)
        {
            TextBox_Inicial.Text = "";
            TextBox_Final.Text = "";
            ListBox1.Items.Clear();
        }
    }
}
    
        

