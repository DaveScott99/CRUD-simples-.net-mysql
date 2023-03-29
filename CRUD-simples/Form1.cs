using MySql.Data.MySqlClient;

namespace CRUD_simples
{
    public partial class Form1 : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=@frost2016;database=db_agenda";

        private int? id_contato_selecionado = null;

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

            carregarContatos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                // Criar conexão com MySql
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                if (id_contato_selecionado == null)
                {
                    // Inserção de Contato
                    cmd.CommandText = "INSERT INTO db_agenda.contato (NOME_CONTATO, EMAIL_CONTATO, TELEFONE_CONTATO) " +
                                 "VALUES " +
                                 "(@nome, @email, @telefone)";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Inserido com Sucesso",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Atualização de Contato
                    cmd.CommandText = "UPDATE db_agenda.contato " +
                                      "SET NOME_CONTATO=@nome, EMAIL_CONTATO=@email, TELEFONE_CONTATO=@telefone " +
                                      "WHERE " +
                                      "ID_CONTATO=@id";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Atualizado com Sucesso",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                id_contato_selecionado = null;

                txtNome.Text = String.Empty;
                txtEmail.Text = "";
                txtTelefone.Text = "";

                carregarContatos();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                            "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM db_agenda.contato " +
                                  "WHERE NOME_CONTATO LIKE " +
                                  "@busca OR EMAIL_CONTATO LIKE @busca";


                cmd.Parameters.AddWithValue("@busca", "%" + txtBusca.Text + "%");

                cmd.Prepare();

                // Variável para armazenar os dados da requisição
                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstContatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                            "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void carregarContatos()
        {
            try
            {

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM db_agenda.contato ORDER BY ID_CONTATO ASC";

                cmd.Prepare();

                // Variável para armazenar os dados da requisição
                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstContatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                            "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            // Cria uma coleção de itens da lista;
            ListView.SelectedListViewItemCollection itens_selecionados = lstContatos.SelectedItems;

            // Percorre cada item um por vez e seleciona um especifico;
            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id_contato_selecionado = null;

            txtNome.Text = String.Empty;
            txtEmail.Text = "";
            txtTelefone.Text = "";

            txtNome.Focus();
        }
    }
}