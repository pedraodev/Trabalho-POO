using System.Windows.Forms;

namespace Trabalho_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            salariomes salariomes = new salariomes();
            INSS inss = new INSS();
            

            
            double salarioliquido, horas, valor;


            valor = double.Parse(txtvalor.Text);
            horas = double.Parse(txthora.Text);

            salariomes.valorhora = valor;
            salariomes.horastrabalhadas = horas;

            double salariomensal = salariomes.valorsalario();
            double Desconto = inss.DescontoINSS(salariomensal);
            
            
            salarioliquido = salariomensal - inss.Desconto;
                        
            txtresultado.Text += salarioliquido.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtresultado_Click(object sender, EventArgs e)
        {
           
            //matricula = txtcargo;

            
            //txtresultado.Text = btnnome.Text;
            //txtresultado.Text = btnmatricula.Text;
            //txtresultado.Text = btncargo.Text;
        }

        private void btndecimo_Click(object sender, EventArgs e)
        {
            decimoterceiro decimo = new decimoterceiro();
            salariomes rsalario = new salariomes();

            double salariol, dterceiro, resultdecimo;

            dterceiro = double.Parse(txtmeses.Text);
            salariol = rsalario.valorsalario();


            decimo.salarioliquido = salariol;
            decimo.mesestrabalhados = dterceiro;

            resultdecimo = decimo.valordecimo();

            lblrdecimo.Text = resultdecimo.ToString("C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncompleto_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();


            string nome, matricula, cargo;


            funcionario.nome = txtnome.Text;
            funcionario.matricula = txtmatricula.Text;
            funcionario.cargo = txtcargo.Text;

            nome = txtnome.Text;
            matricula = txtmatricula.Text;
            cargo = txtcargo.Text;

            //txtresultado.Text = nome;
            //txtresultado.Text += matricula;
            //txtresultado.Text += cargo;

            txtcompleto.Text = "Funcionário: " + nome + ", Matricula: " + matricula + " ,Com o cargo: " + cargo;
        }
    }
}