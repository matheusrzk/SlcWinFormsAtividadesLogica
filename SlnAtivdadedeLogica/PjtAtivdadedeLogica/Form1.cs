namespace PjtAtivdadedeLogica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1, nota2, nota3, mediaaluno;
            int faltas;

            nota1 = decimal.Parse(txtNota1.Text);
            nota2 = decimal.Parse(txtNota2.Text);
            nota3 = decimal.Parse(txtNota3.Text);
            faltas = int.Parse(txtFaltas.Text);

            mediaaluno = nota1 + nota2 + nota3 / 3;

            if (faltas >= 12)
            {
                lblMensagem.Text = "Reprovado por faltas!";
            }
            else if (mediaaluno<4)
            {
                lblMensagem.Text = "Reprovado por Nota!";
            }
            else if (mediaaluno >= 4 && mediaaluno <=5.5m)
            {
                lblMensagem.Text = "Concelho de Classe!";
            }
            else
            {
                lblMensagem.Text = "Aprovado!";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}