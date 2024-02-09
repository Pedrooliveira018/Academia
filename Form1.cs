using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculaImc()
        {
            decimal peso = numpeso.Value;
            decimal altura = numaltura.Value;

            if (peso == 0 ||  altura == 0) 
            {
                return;
            }
            decimal imc = peso / (altura * altura);

            lblresultado.Text = imc.ToString(); 
        }
        private void mlagua()
        {
            decimal peso = numpeso2.Value;
            int ml = 35;
            if (peso == 0)
            {
                return;
            }
            decimal totalagua = ml * peso / 1000;
            lblresultado2.Text = totalagua.ToString();
        }
        private void calculacaloriasgastas()
        {
            decimal peso = numpeso3.Value;
            DateTime horaduracao = dateduracao.Value;
            int atividade = cmbatividade.SelectedIndex;

            int horas = horaduracao.Hour;
            int minutos = horaduracao.Minute;

            decimal duracaoAtividade = (horas * 60) +minutos;
         
            decimal met = 0;
            if (atividade == 1)
                met = 11.5m;
            else if (atividade == 2)
                met = 6;
            else if (atividade == 3)
                met = 9;
            else if (atividade == 4)   
                met = 13.5m;

            decimal calorias = met * peso * (duracaoAtividade / 60);

            lbl3.Text = calorias.ToString("f2");

        }
    
        private void bnt1_Paint(object sender, PaintEventArgs e)


        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calculacaloriasgastas();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CalculaImc();
        }

        private void numpeso_ValueChanged(object sender, EventArgs e)
        {
            CalculaImc();
        }

        private void numpeso2_ValueChanged(object sender, EventArgs e)
        {
            mlagua ();  
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mlagua();   
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void numpeso3_ValueChanged(object sender, EventArgs e)
        {
            calculacaloriasgastas();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            calculacaloriasgastas();
        }
    }
}
