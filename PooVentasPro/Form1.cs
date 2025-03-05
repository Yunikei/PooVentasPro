using System.Diagnostics.Contracts;

namespace PooVentasPro
{
    //Clase
    public partial class Form1 : Form
    {
        //Asignamos variables
        public double totContado, totCredito,totalContado=0, totalCredito=0, totalNeto=0;
        public Form1()
        {
            InitializeComponent();
            // _venta = new Venta();
            //  DgvArticulos.AutoGenerateColumns = false;
            //DgvArticulos.Columns.Add("Contado", "Cr�dito");
        }
        private void RdContado_CheckedChanged(Object sender, EventArgs e)
        {
            if (RdContado.Checked)
            {
                DgvArticulos.Rows.Add("Contado");
            }
        }
        //M�todos fallidos jeje
        private void RdCr�dito_CheckedChanged(Object sender, EventArgs e)
        {
            
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RdContado_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        //Forma directa de programar
        //M�todo para programar click de "Contado", ademas de programar c�mo se reflejaran los n�meros que corresponden a su columna en el formulario
        private void RdContado_Click(object sender, EventArgs e)
        {
            totContado = float.Parse(txtPre.Text) * float.Parse(txtCan.Text);
            totalContado = totalContado + totContado;
            txtTotContado.Text = totalContado.ToString();
            totalNeto = totalNeto + totalContado;
            txtTotalNeto.Text = totalNeto.ToString();
            DgvArticulos.Rows.Add(txtPre.Text, txtCan.Text, totContado.ToString());
        }

        //M�todo para programar click de "Cr�dito", Se programa igual su forma de reflejar los n�meros en su columna en el form.
        private void RdCredito_Click(object sender, EventArgs e)
        {
            totCredito = (double.Parse(txtPre.Text) * double.Parse(txtCan.Text));
            totCredito = totCredito * 1.05;
            totalCredito = totalCredito + totCredito;
            txtTotCredito.Text = totalCredito.ToString();
            totalNeto = totalNeto + totalCredito;
            txtTotalNeto.Text = totalNeto.ToString();
            DgvArticulos.Rows.Add(txtPre.Text, txtCan.Text, 0, totCredito.ToString());
        }
    }
}
