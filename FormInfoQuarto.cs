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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*// Aqui você pode coletar as informações do cliente do formulário
            string nomeCliente = textBoxNome.Text;
            string telefoneCliente = textBoxTelefone.Text;

            // Agora você pode associar as informações do cliente ao quarto
            quartoAssociado.InformacoesCliente = $"Nome: {nomeCliente}, Telefone: {telefoneCliente}";

            MessageBox.Show("Informações do cliente associadas ao quarto.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();*/
        }

    }
}
