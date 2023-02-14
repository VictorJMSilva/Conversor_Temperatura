using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Temperatura
{
    public partial class frmConvertTemp : Form
    {
        public frmConvertTemp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void combocf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConvertTemp_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
        //Rodrigo Vieira dos Santos RA 216264
        //Victor de Jesus Mota Silva RA 121824
            if(this.combocf.SelectedIndex == 0)
            {
                float Celsius = 0;
                if (float.TryParse(TxtValor.Text, out Celsius))
                {
                    float fahrenheit = (float)(Celsius * 1.8) +32;
                    TxtFinal.Text = $"{fahrenheit:N1}";
                }
                else
                {
                    MessageBox.Show("Digite um valor correto!");
                    TxtValor.Text = "";
                }
            }
            else if (this.combocf.SelectedIndex == 1)
            {
                {
                    float fahrenheit = 0;
                    if (float.TryParse(TxtValor.Text, out fahrenheit))
                    {
                        float Celsius = (float)((fahrenheit - 32) / 1.8);
                        TxtFinal.Text = $"{Celsius:N1}";
                    }
                    else
                    {
                        MessageBox.Show("Digite um valor correto!");
                        TxtValor.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um dos tipos de conversão.");
            }
        }
    }
}
