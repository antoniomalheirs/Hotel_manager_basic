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
            // Aqui voc� pode implementar a l�gica para obter informa��es do quarto
            // com base no n�mero do quarto clicado e retornar essas informa��es como uma string
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

            // Se o n�mero do quarto n�o for encontrado, retorne uma mensagem gen�rica
            return "Informa��es n�o dispon�veis para o quarto " + numeroQuarto;
        }


        private void Botao_Click(object sender, EventArgs e)
        {
            // Verifica qual bot�o foi clicado
            Button botaoClicado = (Button)sender;

            // Obt�m informa��es do quarto com base no bot�o clicado
            string numeroQuarto = botaoClicado.Text; // Assumindo que o texto do bot�o � o n�mero do quarto
            string informacoesQuarto = ObterInformacoesQuarto(numeroQuarto); // Substitua isso pela l�gica real para obter informa��es

            // Exibe as informa��es em algum lugar, como um r�tulo
            MessageBox.Show(informacoesQuarto, "Informa��es do Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}