namespace school_books
{
    partial class Book
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
            this.m_role = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_link = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_altname = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_role});
            this.menuStrip1.Location = new System.Drawing.Point(0, 287);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_role
            // 
            this.m_role.Name = "m_role";
            this.m_role.Size = new System.Drawing.Size(195, 24);
            this.m_role.Text = "Уровень доступа: Админ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Альтернативные\r\nназвания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категория";
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(133, 211);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(55, 16);
            this.lbl_link.TabIndex = 5;
            this.lbl_link.Text = "Ссылка";
            this.lbl_link.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(136, 12);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(652, 56);
            this.txt_name.TabIndex = 6;
            // 
            // txt_altname
            // 
            this.txt_altname.Enabled = false;
            this.txt_altname.Location = new System.Drawing.Point(136, 75);
            this.txt_altname.Multiline = true;
            this.txt_altname.Name = "txt_altname";
            this.txt_altname.Size = new System.Drawing.Size(652, 56);
            this.txt_altname.TabIndex = 6;
            // 
            // txt_author
            // 
            this.txt_author.Enabled = false;
            this.txt_author.Location = new System.Drawing.Point(136, 137);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(652, 22);
            this.txt_author.TabIndex = 6;
            // 
            // combo_category
            // 
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.Enabled = false;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(136, 166);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(301, 24);
            this.combo_category.TabIndex = 7;
            this.combo_category.SelectedIndexChanged += new System.EventHandler(this.combo_category_SelectedIndexChanged);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(12, 204);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(104, 30);
            this.btn_download.TabIndex = 8;
            this.btn_download.Text = "Скачать";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 240);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 30);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(684, 240);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 30);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Изменить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(194, 208);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(594, 22);
            this.txt_link.TabIndex = 9;
            this.txt_link.Visible = false;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(136, 211);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(44, 16);
            this.lbl_result.TabIndex = 10;
            this.lbl_result.Text = "label6";
            this.lbl_result.Visible = false;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(444, 167);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(344, 22);
            this.txt_category.TabIndex = 26;
            this.txt_category.Visible = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_altname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Book";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебник";
            this.Load += new System.EventHandler(this.Book_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_link;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_altname;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_category;
    }
}