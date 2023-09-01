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
    public partial class FormHospedeCobrar : Form
    {
        private List<Hospede> Devedores;

        public FormHospedeCobrar(List<Hospede> devedores)
        {
            InitializeComponent();
            Devedores = devedores;
        }

        private void FormHospedeCobrar_Load(object sender, EventArgs e)
        {

            lista.Nodes.Clear();

            foreach (Hospede devedor in Devedores)
            {
                TreeNode node = new TreeNode($"Quarto {devedor.NumeroQuarto}");
                node.Nodes.Add($"Nome..: {devedor.Nome}");
                node.Nodes.Add($"Telefone..: {devedor.Telefone}");
                node.Nodes.Add($"Nome..: {devedor.Email}");
                node.Nodes.Add($"Nome..: {devedor.Diashospedado}");
                node.Nodes.Add($"Nome..: {devedor.Pagar}");
                lista.Nodes.Add(node);

            }
        }

        private void Liberadevedor_Click(object sender, EventArgs e)
        {
            if (lista.SelectedNode != null && lista.SelectedNode.Parent == null)
            {
                DialogResult result = MessageBox.Show("O hospede efetivou o pagamento?", "Janela de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = MessageBox.Show("Tem certeza ?", "Reaviso de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result2 == DialogResult.Yes)
                    {
                        lista.Nodes.Remove(lista.SelectedNode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um quarto antes de confirmar o pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
