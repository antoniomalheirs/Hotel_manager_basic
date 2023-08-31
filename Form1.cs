namespace Apredizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string ObterInformacoesQuarto(string numeroQuarto)
        {
            // Aqui você pode implementar a lógica para obter informações do quarto
            // com base no número do quarto clicado e retornar essas informações como uma string
            // Exemplo:
            if (numeroQuarto == "101")
            {
                return "Quarto 101: 1 cama de casal, TV, banheiro privativo.";
            }
            else if (numeroQuarto == "102")
            {
                return "Quarto 102: 2 camas de solteiro, ar-condicionado, banheiro privativo.";
            }
            // ... e assim por diante

            // Se o número do quarto não for encontrado, retorne uma mensagem genérica
            return "Informações não disponíveis para o quarto " + numeroQuarto;
        }


        private void Botao_Click(object sender, EventArgs e)
        {
            // Verifica qual botão foi clicado
            Button botaoClicado = (Button)sender;

            // Obtém informações do quarto com base no botão clicado
            string numeroQuarto = botaoClicado.Text; // Assumindo que o texto do botão é o número do quarto
            string informacoesQuarto = ObterInformacoesQuarto(numeroQuarto); // Substitua isso pela lógica real para obter informações

            // Exibe as informações em algum lugar, como um rótulo
            MessageBox.Show(informacoesQuarto, "Informações do Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}