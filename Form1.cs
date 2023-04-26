using System.Windows.Forms;

namespace Escola
{
    public partial class bancoescola : Form
    {
        List<Dados> listaDados = new List<Dados>();
        public bancoescola()
        {
            InitializeComponent();
            dataGridView2.Columns.Add("MediaValue", "");
            dataGridView2.Columns["MediaValue"].DataPropertyName = "MediaValue";
            dataGridView2.Columns["MediaValue"].DefaultCellStyle.Format = "N2";

        }

        private void gravar_Click(object sender, EventArgs e)
        {
            var dados = new Dados();
            if (dados.JsonSerializarLista(listaDados, @"C:\Users\Estudos C#\source\repos\Escola\dadosescola.json"))
                MessageBox.Show("Dados Salvos!");
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            var listaDados = Dados.JsonDesserializarLista(@"C:\Users\Estudos C#\source\repos\Escola\dadosescola.json");

            dataGridView1.DataSource = listaDados;
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            var dados = new Dados();
            dados.Matricula = int.Parse(textMatricula.Text);
            dados.Sala = textSala.Text;
            dados.Aluno = textNome.Text;
            dados.Nota1 = float.Parse(textNota1.Text);
            dados.Nota2 = float.Parse(textNota2.Text);

            listaDados.Add(dados);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView2.Rows[e.RowIndex];
                var nota1 = float.Parse(selectedRow.Cells["Nota1"].Value.ToString());
                var nota2 = float.Parse(selectedRow.Cells["Nota2"].Value.ToString());
                var media = (nota1 + nota2) / 2;

                selectedRow.Cells["Media"].Value = media.ToString();
            }
        }
    }
}