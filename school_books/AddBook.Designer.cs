namespace school_books
{
    partial class AddBook
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
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_altname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_link = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_role = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(136, 196);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(652, 22);
            this.txt_link.TabIndex = 24;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(684, 235);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 30);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 235);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 30);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // combo_category
            // 
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(136, 164);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(301, 24);
            this.combo_category.TabIndex = 20;
            this.combo_category.SelectedIndexChanged += new System.EventHandler(this.combo_category_SelectedIndexChanged);
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(136, 135);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(652, 22);
            this.txt_author.TabIndex = 17;
            // 
            // txt_altname
            // 
            this.txt_altname.Location = new System.Drawing.Point(136, 73);
            this.txt_altname.Multiline = true;
            this.txt_altname.Name = "txt_altname";
            this.txt_altname.Size = new System.Drawing.Size(652, 56);
            this.txt_altname.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(136, 10);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(652, 56);
            this.txt_name.TabIndex = 19;
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Location = new System.Drawing.Point(75, 199);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(55, 16);
            this.lbl_link.TabIndex = 16;
            this.lbl_link.Text = "Ссылка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Альтернативные\r\nназвания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Авторы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_role});
            this.menuStrip1.Location = new System.Drawing.Point(0, 279);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_role
            // 
            this.m_role.Name = "m_role";
            this.m_role.Size = new System.Drawing.Size(195, 24);
            this.m_role.Text = "Уровень доступа: Админ";
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(444, 165);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(344, 22);
            this.txt_category.TabIndex = 25;
            this.txt_category.Visible = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
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
            this.Name = "AddBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый учебник";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_altname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_role;
        private System.Windows.Forms.TextBox txt_category;
    }
}