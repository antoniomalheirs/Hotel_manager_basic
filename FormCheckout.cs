using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Apredizado
{
    public partial class FormCheckout : Form
    {
        private List<Quarto> Hospedados;

        public FormCheckout(List<Quarto> hospedados)
        {
            InitializeComponent();
            Hospedados = hospedados;
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            lista.Nodes.Clear();

            foreach (Quarto hospede in Hospedados)
            {
                if (hospede.Reservado == true)
                {
                    TreeNode node = new TreeNode($"Quarto {hospede.Numero}");
                    node.Nodes.Add($"Nome: {hospede.Hospede.Nome}");
                    node.Nodes.Add($"Telefone: {hospede.Hospede.Telefone}");
                    node.Nodes.Add($"CPF: {hospede.Hospede.Cpf}");
                    node.Nodes.Add($"Dias cobrados: {hospede.Hospede.Diashospedado}");
                    node.Nodes.Add($"Devendo: {hospede.Hospede.Pagar}");
                    lista.Nodes.Add(node);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;
            string telefoneCliente = txtTelefone.Text;
            string valor = txtValor.Text;
            string cpfCliente = txtCpf.Text;

            if (lista.SelectedNode != null && lista.SelectedNode.Parent == null && nomeCliente != "")
            {
                DialogResult result = MessageBox.Show("O hospede efetivou o pagamento?", "Janela de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = MessageBox.Show("Tem certeza ?", "Reaviso de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result2 == DialogResult.Yes)
                    {
                        foreach (Quarto hospede in Hospedados)
                        {
                            if (hospede.Reservado != false && hospede.Hospede != null)
                            {
                                if (hospede.Hospede.Cpf == cpfCliente && hospede.Hospede.Pagar == double.Parse(valor) && hospede.Hospede.Nome == nomeCliente && hospede.Hospede.Telefone == telefoneCliente)
                                {
                                    foreach (TreeNode node in lista.Nodes)
                                    {
                                        if (node.Text == "Quarto "+hospede.Numero)
                                        {
                                            lista.Nodes.Remove(node);
                                            hospede.Reservado = false;
                                            hospede.Hospede = null;
                                            txtNome.Clear();
                                            txtTelefone.Clear();
                                            txtValor.Clear();
                                            txtCpf.Clear();
                                            MessageBox.Show("Check-Out Realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            goto fim;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Verifique os dados, divergência de informações", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fim:;
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos para realizar o check-out \nSelecione o quarto a realizar a operação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
