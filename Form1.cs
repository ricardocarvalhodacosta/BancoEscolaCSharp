namespace Escola
{
    public partial class bancoescola : Form
    {
        public bancoescola()
        {
            InitializeComponent();
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            var dados = new Dados();
            dados.Matricula = int.Parse(textMatricula.Text);
            dados.Sala = char.Parse(textSala.Text);
            dados.Aluno = textNome.Text;
            dados.Nota1 = float.Parse(textNota1.Text);
            dados.Nota2 = float.Parse(textNota2.Text);
            dados.Media = float.Parse(textMedia.Text);

            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Estudos C#\source\repos\Escola\dadosescola.json"))
                {
                    sw.WriteLine(dados.JsonSerializar(dados));
                }

                MessageBox.Show("Arquivo salvo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            try
            {
                var strJson = "";

                using (StreamReader sr = new StreamReader(@"C:\Users\Estudos C#\source\repos\Escola\dadosescola.json"))
                {
                    strJson = sr.ReadToEnd();
                }

                var dados = Dados.JsonDesserializar(strJson);

                dados.Matricula = int.Parse(textMatricula.Text);
                dados.Sala = char.Parse(textSala.Text);
                dados.Aluno = textNome.Text;
                dados.Nota1 = float.Parse(textNota1.Text);
                dados.Nota2 = float.Parse(textNota2.Text);
                dados.Media = float.Parse(textMedia.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }
    }
}