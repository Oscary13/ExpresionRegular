using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionRegular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_Coincidencias.Items.Clear();
            //Match resultado;
            MatchCollection resultado1;
            //Regex expresion = new Regex("[A-Z][AEIOU][A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM](DF|HG|MC)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z][0-9]");
            //resultado = expresion.Match("HEHR021224HDFRRLA6");

            //Regex expresion1 = new Regex("([A-Z]|[ÁÉÍÓÚ])([a-z]|[áéíóú])+");
            //Regex expresion1 = new Regex("(\+52)([- | ][0-9][0-9]|[0-9][0-9]){5}");

            //Regex expresion1 = new Regex("(\+52|52)?(\-| )?([0-9]{2}(\-|0))");

            if (textBox_ExpresionRegular.Text == "")
            {
                MessageBox.Show("Ingresa Expresion regular");
            }
            else
            {
                if (richTextBox_Cadena.Text == "")
                {
                    MessageBox.Show("Ingresa el texto a validar");
                }
                else
                {
                    Regex expresion1 = new Regex(textBox_ExpresionRegular.Text);
                    var cadena = richTextBox_Cadena.Text;
                    Console.WriteLine(cadena);
                    resultado1 = expresion1.Matches(cadena);

                    foreach (Match match in resultado1)
                    {
                        Console.WriteLine(match.Value);
                        listBox_Coincidencias.Items.Add(match.Value);
                    }
                }
            }
           
        }
    }
}
