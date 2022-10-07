namespace Treino
{
    public partial class TelaCalcular : Form
    {
        public TelaCalcular()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbresultado.Items.Clear();
            numeroum.Value = 0;
            numerodois.Value = 0;
            
        }     

        private void button4_Click(object sender, EventArgs e)
        {
            TelaCreditos novatelaCreditos = new TelaCreditos();
            novatelaCreditos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            if(Cbopaçao.Text == "+")
            {
                resultado = Convert.ToDouble(numeroum.Value + numerodois.Value);
            }
            else if(Cbopaçao.Text == "-")
            {
                resultado = Convert.ToDouble(numeroum.Value - numerodois.Value);
            }
            else if (Cbopaçao.Text == "/")
            {
                resultado = Convert.ToDouble(numeroum.Value / numerodois.Value);
            }
            else if (Cbopaçao.Text == "*")
            {
                resultado = Convert.ToDouble(numeroum.Value * numerodois.Value);
            }

            lbresultado.Items.Add(Convert.ToString (resultado));
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numeroum_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}