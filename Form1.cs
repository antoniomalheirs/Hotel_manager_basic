namespace Apredizado
{
    public partial class Form1 : Form
    {
        private List<Quarto> quartos = new List<Quarto>();
        private Quarto main = new Quarto("000", "Administrador");

        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            quartos = main.PreencherInformacoesQuartos();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000; // Define o intervalo em milissegundos (1 segundo neste exemplo)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Verifica o horário atual
            DateTime horarioAtual = DateTime.Now;

            // Percorre os quartos alugados e verifica se a diária acabou
            foreach (Quarto quarto in quartos)
            {
                if (quarto.Reservado == true && quarto.Hospede.DataCheckOut <= DateTime.Now)
                {
                    MessageBox.Show($"Hospedagem quarto {quarto.Numero} terminada \nHospede {quarto.Hospede.Nome}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quarto.Reservado = false;
                    quarto.Hospede = null;
                }
            }
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