namespace Apredizado
{
    public partial class Form1 : Form
    {
        private List<Quarto> quartos = new List<Quarto>();
        private List<Hospede> hospedes = new List<Hospede>();
        private Quarto main = new Quarto("000", "Administrador", 0);

        private double montante = 0;

        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            quartos = main.PreencherInformacoesQuartos();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirHospedagemFormulario(object quartoObj)
        {
            Quarto quarto = (Quarto)quartoObj;
            FormInfoQuarto formCliente = new FormInfoQuarto(quarto);

            formCliente.ShowDialog();
        }
        private void AbrirCobrarFormulario()
        {
            FormHospedeCobrar formCliente = new FormHospedeCobrar(hospedes);
            formCliente.ShowDialog();
        }
        private void AbrirCheckout()
        {
            FormCheckout formCliente = new FormCheckout(quartos);
            formCliente.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Quarto quarto in quartos)
            {
                if (quarto.Reservado == true && quarto.Hospede.DataCheckOut <= DateTime.Now)
                {
                    hospedes.Add(quarto.Hospede);
                    quarto.Hospede = null;
                    quarto.Reservado = false;

                    MessageBox.Show($"Hospedagem do Quarto {quarto.Numero} Terminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                    DialogResult result = MessageBox.Show("Deseja abrir hospedagem ?" + "\nValor da Diaria...: " + quarto.Diaria + "\nAcomodações...: " + quarto.Descricao, "Janela de Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Thread thread = new Thread(AbrirHospedagemFormulario);
                        thread.Start(quarto);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Quarto em uso", "Visualizar Informações ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Thread thread = new Thread(AbrirHospedagemFormulario);
                        thread.Start(quarto);
                    }
                }

            }
            else
            {
                MessageBox.Show("Quarto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(AbrirCobrarFormulario);
            thread.Start();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(AbrirCheckout);
            thread.Start();
        }
    }
}