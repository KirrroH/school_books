using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school_books
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            fill_combo();
        }

        private void fill_combo()
        {
            combo_category.Items.Clear();

            string query = "select name_category from category;";
            MySqlConnection conn = DBUtils.get_conn();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                combo_category.Items.Add("нет в списке");

                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    combo_category.Items.Add(rdr[0]);
                }
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((txt_name.Text != "") && (txt_altname.Text != "") && (txt_author.Text != "") && (txt_link.Text != "") && ((combo_category.SelectedIndex > 0) || (combo_category.SelectedIndex == 0) && (txt_category.Text != "")))
            {
                string query = "";

                if (combo_category.SelectedIndex == 0)
                {
                    string query_cat = $"insert into category (name_category) values ('{txt_category.Text}');\n";
                    string query_book = $"insert into book (name_book, altname_book, author_book, category_book, link_book) values ('{txt_name.Text}', '{txt_altname.Text}', '{txt_author.Text}', (select id_category from category where name_category = '{txt_category.Text}'), '{txt_link.Text}');";
                    query = query_cat + query_book;
                }
                else query = $"insert into book (name_book, altname_book, author_book, category_book, link_book) values ('{txt_name.Text}', '{txt_altname.Text}', '{txt_author.Text}', (select id_category from category where name_category = '{combo_category.SelectedItem}'), '{txt_link.Text}');";
                
                MySqlConnection conn = DBUtils.get_conn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else MessageBox.Show("Должны быть заполнены все поля.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void combo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_category.SelectedIndex == 0) txt_category.Visible = true;
            else txt_category.Visible = false;
        }
    }
}