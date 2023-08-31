using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apredizado
{
    public partial class FormInfoQuarto : Form
    {
        private Quarto? quartoAssociado;

        public FormInfoQuarto(Quarto quarto)
        {
            InitializeComponent();
            quartoAssociado = quarto;
            numero.Text = "Quarto -- " + quarto.Numero;
            descricao.Text = quarto.Descricao;

            if (quartoAssociado.Hospede != null)
            {
                txtNome.Text = quartoAssociado.Hospede.Nome;
                txtTelefone.Text = quartoAssociado.Hospede.Telefone;
                txtEmail.Text = quartoAssociado.Hospede.Email;
                entrada.Text = quartoAssociado.Hospede.DataCheckIn.ToString();
                saida.Text = quartoAssociado.Hospede.DataCheckOut.ToString();
                dias.Value = quartoAssociado.Hospede.Diashospedado;
                txtcpf.Text = quartoAssociado.Hospede.Cpf;
                nascimento.Text = quartoAssociado.Hospede.Nascimento.ToString();


                salvahospede.Enabled = false;
                txtNome.Enabled = false;
                txtTelefone.Enabled = false;
                txtEmail.Enabled = false;
                txtcpf.Enabled = false;
                dias.Enabled = false;
                nascimento.Enabled = false;
            }
        }

        private void salvahospede_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;
            string telefoneCliente = txtTelefone.Text;
            string emailCliente = txtEmail.Text;
            string cpfCliente = txtcpf.Text;
            string numeroQuarto = quartoAssociado.Numero;
            DateTime dataCheckIn = DateTime.Now;
            DateTime dataCheckOut = DateTime.Now;
            DateTime nasciment = nascimento.Value;
            DateTime newdate = dataCheckOut.AddDays((int)dias.Value);
            quartoAssociado.Reservado = true;

            Hospede hospede = new Hospede(nomeCliente, telefoneCliente, emailCliente, cpfCliente, dataCheckIn, newdate, nasciment, numeroQuarto, (int)dias.Value, 0);
            quartoAssociado.Hospede = hospede;
            quartoAssociado.Hospede.Pagar = (int)dias.Value * quartoAssociado.Diaria;

            MessageBox.Show("Informações do cliente associadas ao quarto.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FormInfoQuarto_Load(object sender, EventArgs e)
        {

        }
    }
}
