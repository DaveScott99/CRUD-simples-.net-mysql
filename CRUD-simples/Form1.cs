using MySql.Data.MySqlClient;

namespace CRUD_simples
{
    public partial class Form1 : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=@frost2016;database=db_agenda";

        public Form1()
        {
            InitializeComponent();

            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;

            lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // Criar conexão com MySql
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO db_agenda.contato (NOME_CONTATO, EMAIL_CONTATO, TELEFONE_CONTATO) " +
                                "VALUES " +
                                "('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "') ";

                // Executar comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Contato inserido com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                string query = "'%" + txtBusca.Text + "%'";

                // Criar conexão com MySql
                Conexao = new MySqlConnection(data_source);

                // Comando SQL
                string sql = "SELECT * " +
                             "FROM db_agenda.contato " +
                             "WHERE NOME_CONTATO LIKE " + query + "OR EMAIL_CONTATO LIKE " + query;

                Conexao.Open();

                // Executar comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                // Variável para armazenar os dados da requisição
                MySqlDataReader reader = comando.ExecuteReader();

                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_list_view = new ListViewItem(row);

                    lstContatos.Items.Add(linha_list_view);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}