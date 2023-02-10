using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school_books
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void fill_combo()
        {
            combo_category.Items.Clear();

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

        private void Search_Load(object sender, EventArgs e)
        {
            fill_combo();
        }

        private void fill_grid(string cond)
        {
            dgv_books.Rows.Clear();

            int num = 1;

            string query = $"select id_book, name_book, author_book from book where category_book = (select id_category from category where name_category = '{combo_category.SelectedItem}'){cond};";
            MySqlConnection conn = DBUtils.get_conn();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dgv_books.Rows.Add(rdr[0], num, rdr[1], rdr[2]);
                    num++;
                }
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void clear()
        {
            combo_category.SelectedIndex = -1;
            txt_name.Clear();
            txt_author.Clear();
            dgv_books.Rows.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void combo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_category.SelectedIndex > -1)
            {
                txt_author.Enabled = true;
                txt_name.Enabled = true;
                dgv_books.Enabled = true;

                fill_grid("");
            }
            else
            {
                txt_author.Enabled = false;
                txt_name.Enabled = false;
                dgv_books.Enabled = false;
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if ((txt_name.Text != "") && (txt_author.Text != "")) fill_grid($" and (name_book like '%{txt_name.Text}%' or altname_book like '%{txt_name.Text}%') and author_book like '%{txt_author.Text}%'");
            else if ((txt_name.Text != "") && (txt_author.Text == "")) fill_grid($" and (name_book like '%{txt_name.Text}%' or altname_book like '%{txt_name.Text}%')");
            else if ((txt_name.Text == "") && (txt_author.Text == "")) fill_grid("");
            else if ((txt_name.Text == "") && (txt_author.Text != "")) fill_grid($" and author_book like '%{txt_author.Text}%'");
        }

        private void txt_author_TextChanged(object sender, EventArgs e)
        {
            if ((txt_name.Text != "") && (txt_author.Text != "")) fill_grid($" and (name_book like '%{txt_name.Text}%' or altname_book like '%{txt_name.Text}%') and author_book like '%{txt_author.Text}%'");
            else if ((txt_name.Text == "") && (txt_author.Text != "")) fill_grid($" and author_book like '%{txt_author.Text}%'");
            else if ((txt_name.Text == "") && (txt_author.Text == "")) fill_grid("");
            else if ((txt_name.Text != "") && (txt_author.Text == "")) fill_grid($" and (name_book like '%{txt_name.Text}%' or altname_book like '%{txt_name.Text}%')");
        }

        private void dgv_books_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (selectedRow > -1)
            {
                DataGridViewRow Row = dgv_books.Rows[selectedRow];

                string id_book = Row.Cells[0].Value.ToString();

                Book win = new Book(id_book);
                win.Owner = this;
                win.Show();
                clear();
                this.Hide();
            }
        }

        private void m_addBook_Click(object sender, EventArgs e)
        {
            AddBook win = new AddBook();
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void link_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fill_combo();
        }
    }
}