namespace Apredizado
{
    public partial class Form1 : Form
    {
        private List<Quarto> quartos = new List<Quarto>();
        private Quarto main = new Quarto("000","Administrador");
        public Form1()
        {
            InitializeComponent();
            quartos = main.PreencherInformacoesQuartos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Botao_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            string numeroBotao = botaoClicado.Text;

            Quarto quarto = quartos.Find(q => q.Numero == numeroBotao);

            if (quarto != null)
            {
                MessageBox.Show(quarto.Descricao, "Informações do Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormInfoQuarto formCliente = new FormInfoQuarto(quarto);
                formCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Quarto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}