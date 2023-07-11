namespace Pedra_Papel_e_Tesoura
{
    public partial class Form1 : Form
    {
        public string escolha_usuario, escolha_computador;
        public int numero;
        string[] opcoes =
        {
            "PEDRA",
            "PAPEL",
            "TESOURA"
        };

        private void Digite_escolha(string text)
        {
            escolha_usuario = text;
            usuario.Text = escolha_usuario;
            Digite_maquina();
        }
        private void Digite_maquina()
        {
            Random rand = new Random();
            numero = rand.Next(opcoes.Length);
            escolha_computador = opcoes[numero];
            computador.Text = (escolha_computador);

            computador.Text = escolha_computador;
        }
        private void As_escolhas()
        {
            if (escolha_usuario == escolha_computador)
            {
                Vencedor.Text = "Empate!";
            }
            else if (escolha_usuario == "PEDRA" && escolha_computador == "TESOURA")
            {
                Vencedor.Text = "Você venceu!";
            }
            else if (escolha_usuario == "PAPEL" && escolha_computador == "PEDRA")
            {
                Vencedor.Text = "Você venceu!";
            }
            else if (escolha_usuario == "TESOURA" && escolha_computador == "PAPEL")
            {
                Vencedor.Text = "Você venceu!";
            }
            else
            {
                Vencedor.Text = "Você perdeu!";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pedra_Click(object sender, EventArgs e)
        {
            Digite_escolha(opcoes[0]);
            As_escolhas();
            ;
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Papel_Click(object sender, EventArgs e)
        {
            Digite_escolha(opcoes[1]);
            As_escolhas();
            ;
        }

        private void btn_Tesoura_Click(object sender, EventArgs e)
        {
            Digite_escolha(opcoes[2]);
            As_escolhas();
            ;
        }
    }
}