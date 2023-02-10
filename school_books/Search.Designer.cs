namespace school_books
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.m_addBook = new System.Windows.Forms.ToolStripMenuItem();
            this.m_role = new System.Windows.Forms.ToolStripMenuItem();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link_refresh = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.ms_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_role});
            this.menuStrip1.Location = new System.Drawing.Point(0, 499);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(840, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_main
            // 
            this.ms_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_addBook});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(840, 30);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Авторы";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 459);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 30);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // combo_category
            // 
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(94, 35);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(354, 24);
            this.combo_category.TabIndex = 6;
            this.combo_category.SelectedIndexChanged += new System.EventHandler(this.combo_category_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(94, 66);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(734, 22);
            this.txt_name.TabIndex = 7;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_author
            // 
            this.txt_author.Enabled = false;
            this.txt_author.Location = new System.Drawing.Point(94, 94);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(734, 22);
            this.txt_author.TabIndex = 7;
            this.txt_author.TextChanged += new System.EventHandler(this.txt_author_TextChanged);
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.AllowUserToDeleteRows = false;
            this.dgv_books.AllowUserToResizeColumns = false;
            this.dgv_books.AllowUserToResizeRows = false;
            this.dgv_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_books.Enabled = false;
            this.dgv_books.Location = new System.Drawing.Point(12, 131);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(816, 314);
            this.dgv_books.TabIndex = 8;
            this.dgv_books.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentDoubleClick);
            // 
            // m_addBook
            // 
            this.m_addBook.Name = "m_addBook";
            this.m_addBook.Size = new System.Drawing.Size(151, 26);
            this.m_addBook.Text = "Добавить учебник";
            this.m_addBook.Click += new System.EventHandler(this.m_addBook_Click);
            // 
            // m_role
            // 
            this.m_role.Name = "m_role";
            this.m_role.Size = new System.Drawing.Size(195, 26);
            this.m_role.Text = "Уровень доступа: Админ";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 8F;
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "Авторы";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // link_refresh
            // 
            this.link_refresh.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_refresh.AutoSize = true;
            this.link_refresh.Location = new System.Drawing.Point(455, 40);
            this.link_refresh.Name = "link_refresh";
            this.link_refresh.Size = new System.Drawing.Size(71, 16);
            this.link_refresh.TabIndex = 9;
            this.link_refresh.TabStop = true;
            this.link_refresh.Text = "Обновить";
            this.link_refresh.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_refresh_LinkClicked);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 529);
            this.Controls.Add(this.link_refresh);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ms_main);
            this.MainMenuStrip = this.ms_main;
            this.MaximizeBox = false;
            this.Name = "Search";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск учебника";
            this.Load += new System.EventHandler(this.Search_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_role;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem m_addBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.LinkLabel link_refresh;
    }
}