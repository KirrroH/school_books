using System;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school_books
{
    public partial class Book : Form
    {
        public string BookID;

        public Book(string id_book)
        {
            InitializeComponent();

            BookID = id_book;
        }

        private void fill_combo()
        {
            combo_category.Items.Clear();

            combo_category.Items.Add("нет в списке");

            string query = "select name_category from category;";
            MySqlConnection conn = DBUtils.get_conn();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
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

        private void fill_form()
        {
            string query = $"select b.name_book, b.altname_book, b.author_book, c.name_category, b.link_book from book b join category c on b.category_book = c.id_category where b.id_book = {BookID};";
            MySqlConnection conn = DBUtils.get_conn();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txt_name.Text = rdr[0].ToString();
                    txt_altname.Text = rdr[1].ToString();
                    txt_author.Text = rdr[2].ToString();
                    combo_category.SelectedItem = rdr[3].ToString();
                    txt_link.Text = rdr[4].ToString();
                }
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Book_Load(object sender, EventArgs e)
        {
            fill_combo();

            fill_form();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "Скачивается...";
            lbl_result.Visible = true;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            sfd.Filter = "PDF файлы (*.pdf) | *.pdf | Все файлы (*.*)|*.*";

            WebClient wc = new WebClient();

            string url = $"https://drive.google.com/uc?export=download&id={txt_link.Text}";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wc.DownloadFile(url, sfd.FileName);
                lbl_result.Text = "Готово!";
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "Изменить")
            {
                lbl_result.Visible = false;
                txt_name.Enabled = true;
                txt_altname.Enabled = true;
                txt_author.Enabled = true;
                combo_category.Enabled = true;
                txt_link.Visible = true;
                lbl_link.Visible = true;
                btn_edit.Text = "Сохранить";
            }
            else if (btn_edit.Text == "Сохранить")
            {
                string query = "";

                if (combo_category.SelectedIndex == 0)
                {
                    string query_cat = $"insert into category (name_category) values ('{txt_category.Text}');\n";
                    string query_book = $"update book set name_book = '{txt_name.Text}', altname_book = '{txt_altname.Text}', author_book = '{txt_author.Text}', category_book = (select id_category from category where name_category = '{txt_category.Text}'), link_book = '{txt_link.Text}' where id_book = {BookID};";
                    query = query_cat + query_book;
                }
                else query = $"update book set name_book = '{txt_name.Text}', altname_book = '{txt_altname.Text}', author_book = '{txt_author.Text}', category_book = (select id_category from category where name_category = '{combo_category.SelectedItem}'), link_book = '{txt_link.Text}' where id_book = {BookID};";

                MySqlConnection conn = DBUtils.get_conn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    if (txt_category.Text != "")
                    {
                        fill_combo();
                        combo_category.SelectedItem = txt_category.Text;
                    }

                    txt_name.Enabled = false;
                    txt_altname.Enabled = false;
                    txt_author.Enabled = false;
                    combo_category.Enabled = false;
                    txt_link.Visible = false;
                    lbl_link.Visible = false;
                    btn_edit.Text = "Изменить";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void combo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_category.SelectedIndex == 0) txt_category.Visible = true;
            else txt_category.Visible = false;
        }
    }
}