namespace Apredizado
{
    public partial class Form1 : Form
    {
        private List<Quarto> quartos = new List<Quarto>();
        private Quarto main = new Quarto("000", "Administrador");
        public Form1()
        {
            InitializeComponent();
            quartos = main.PreencherInformacoesQuartos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirSegundoFormulario(object quartoObj)
        {
            Quarto quarto = (Quarto)quartoObj;
            FormInfoQuarto formCliente = new FormInfoQuarto(quarto);

            formCliente.ShowDialog();
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            string numeroBotao = botaoClicado.Text;

            Quarto quarto = quartos.Find(q => q.Numero == numeroBotao);

            if (quarto != null)
            {
                if (quarto.Reservado == false)
                {
                    DialogResult result = MessageBox.Show("Deseja abrir hospedagem neste quarto ?" + "\nNum.quarto...: " + quarto.Numero + "\nAcomodações...: " + quarto.Descricao, "Janela de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Thread thread = new Thread(AbrirSegundoFormulario);
                        thread.Start(quarto);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Quarto em uso", "Visualizar Informações ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Thread thread = new Thread(AbrirSegundoFormulario);
                        thread.Start(quarto);
                    }
                }

            }
            else
            {
                MessageBox.Show("Quarto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}