namespace Area_Trapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdcalcular_Click(object sender, EventArgs e)
        {
            double Base1, base2, altura, resultado;
            Base1 = Convert.ToDouble(txtBasemaior.Text);
            base2 = Convert.ToDouble(txtbasemenor.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            resultado = (Base1 + base2) * altura / 2;
            txtresultado.Text = resultado.ToString();

        }
    }
}