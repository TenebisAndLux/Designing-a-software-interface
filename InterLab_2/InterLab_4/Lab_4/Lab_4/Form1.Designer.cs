namespace lab_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAdmin = new DataGridView();
            colAutor = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colIZD = new DataGridViewTextBoxColumn();
            colJanr = new DataGridViewTextBoxColumn();
            colCount = new DataGridViewTextBoxColumn();
            bDow = new Button();
            bSet = new Button();
            bClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbAutor = new TextBox();
            tbName = new TextBox();
            tbYear = new TextBox();
            tbIZD = new TextBox();
            tbJanr = new TextBox();
            tbCount = new TextBox();
            bAdd = new Button();
            bEdit = new Button();
            bDel = new Button();
            label7 = new Label();
            tbAutorS = new TextBox();
            bSearch = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdmin
            // 
            dgvAdmin.AllowUserToAddRows = false;
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Columns.AddRange(new DataGridViewColumn[] { colAutor, colName, colYear, colIZD, colJanr, colCount });
            dgvAdmin.Dock = DockStyle.Fill;
            dgvAdmin.Location = new Point(323, 3);
            dgvAdmin.MultiSelect = false;
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.RowHeadersWidth = 62;
            dgvAdmin.RowTemplate.Height = 23;
            dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmin.Size = new Size(745, 372);
            dgvAdmin.TabIndex = 0;
            // 
            // colAutor
            // 
            colAutor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutor.HeaderText = "Автор";
            colAutor.MinimumWidth = 8;
            colAutor.Name = "colAutor";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Название";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            // 
            // colYear
            // 
            colYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colYear.HeaderText = "Год издания";
            colYear.MinimumWidth = 8;
            colYear.Name = "colYear";
            // 
            // colIZD
            // 
            colIZD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIZD.HeaderText = "Издательство";
            colIZD.MinimumWidth = 8;
            colIZD.Name = "colIZD";
            // 
            // colJanr
            // 
            colJanr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colJanr.HeaderText = "Жанр";
            colJanr.MinimumWidth = 8;
            colJanr.Name = "colJanr";
            // 
            // colCount
            // 
            colCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCount.HeaderText = "Кол-во. страниц";
            colCount.MinimumWidth = 8;
            colCount.Name = "colCount";
            // 
            // bDow
            // 
            bDow.Dock = DockStyle.Top;
            bDow.Location = new Point(3, 3);
            bDow.Name = "bDow";
            bDow.Size = new Size(239, 40);
            bDow.TabIndex = 1;
            bDow.Text = "Загрузить XML";
            bDow.UseVisualStyleBackColor = true;
            bDow.Click += bDow_Click;
            // 
            // bSet
            // 
            bSet.Dock = DockStyle.Top;
            bSet.Location = new Point(248, 3);
            bSet.Name = "bSet";
            bSet.Size = new Size(247, 40);
            bSet.TabIndex = 2;
            bSet.Text = "Выгрузить XML";
            bSet.UseVisualStyleBackColor = true;
            bSet.Click += bSet_Click;
            // 
            // bClear
            // 
            bClear.Dock = DockStyle.Top;
            bClear.Location = new Point(501, 3);
            bClear.Name = "bClear";
            bClear.Size = new Size(241, 40);
            bClear.TabIndex = 3;
            bClear.Text = "Очистить таблицу";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 4;
            label1.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 5;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 6;
            label3.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(3, 96);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 7;
            label4.Text = "Издательство";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(3, 128);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 8;
            label5.Text = "Жанр";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 9;
            label6.Text = "Кол-во. страниц";
            // 
            // tbAutor
            // 
            tbAutor.Dock = DockStyle.Top;
            tbAutor.Location = new Point(159, 3);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(152, 21);
            tbAutor.TabIndex = 10;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Top;
            tbName.Location = new Point(159, 35);
            tbName.Name = "tbName";
            tbName.Size = new Size(152, 21);
            tbName.TabIndex = 11;
            // 
            // tbYear
            // 
            tbYear.Dock = DockStyle.Top;
            tbYear.Location = new Point(159, 67);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(152, 21);
            tbYear.TabIndex = 12;
            // 
            // tbIZD
            // 
            tbIZD.Dock = DockStyle.Top;
            tbIZD.Location = new Point(159, 99);
            tbIZD.Name = "tbIZD";
            tbIZD.Size = new Size(152, 21);
            tbIZD.TabIndex = 13;
            // 
            // tbJanr
            // 
            tbJanr.Dock = DockStyle.Top;
            tbJanr.Location = new Point(159, 131);
            tbJanr.Name = "tbJanr";
            tbJanr.Size = new Size(152, 21);
            tbJanr.TabIndex = 14;
            // 
            // tbCount
            // 
            tbCount.Dock = DockStyle.Top;
            tbCount.Location = new Point(159, 163);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(152, 21);
            tbCount.TabIndex = 15;
            // 
            // bAdd
            // 
            bAdd.Dock = DockStyle.Top;
            bAdd.Location = new Point(3, 195);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(150, 26);
            bAdd.TabIndex = 16;
            bAdd.Text = "Добавить";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.Dock = DockStyle.Top;
            bEdit.Location = new Point(3, 227);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(150, 26);
            bEdit.TabIndex = 17;
            bEdit.Text = "Изменить";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bDel
            // 
            bDel.Dock = DockStyle.Top;
            bDel.Location = new Point(3, 259);
            bDel.Name = "bDel";
            bDel.Size = new Size(150, 26);
            bDel.TabIndex = 18;
            bDel.Text = "Удалить";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bEdit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.ForeColor = SystemColors.InactiveCaptionText;
            label7.Location = new Point(158, 312);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(154, 15);
            label7.TabIndex = 21;
            label7.Text = "Автор для поиска";
            // 
            // tbAutorS
            // 
            tbAutorS.Dock = DockStyle.Top;
            tbAutorS.Location = new Point(158, 332);
            tbAutorS.Margin = new Padding(2);
            tbAutorS.Name = "tbAutorS";
            tbAutorS.Size = new Size(154, 21);
            tbAutorS.TabIndex = 20;
            // 
            // bSearch
            // 
            bSearch.Dock = DockStyle.Top;
            bSearch.ForeColor = SystemColors.InactiveCaptionText;
            bSearch.Location = new Point(3, 333);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(150, 27);
            bSearch.TabIndex = 19;
            bSearch.Text = "Найти";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.96032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.03968F));
            tableLayoutPanel1.Controls.Add(dgvAdmin, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.MaximumSize = new Size(1920, 1080);
            tableLayoutPanel1.MinimumSize = new Size(940, 500);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.4902F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.5098F));
            tableLayoutPanel1.Size = new Size(1071, 501);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Info;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.Controls.Add(bClear, 2, 0);
            tableLayoutPanel2.Controls.Add(bDow, 0, 0);
            tableLayoutPanel2.Controls.Add(bSet, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ForeColor = SystemColors.Highlight;
            tableLayoutPanel2.Location = new Point(323, 381);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(745, 117);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.77169F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.22831F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(tbAutor, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(tbName, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(tbYear, 1, 2);
            tableLayoutPanel3.Controls.Add(label6, 0, 5);
            tableLayoutPanel3.Controls.Add(tbCount, 1, 5);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(tbJanr, 1, 4);
            tableLayoutPanel3.Controls.Add(tbIZD, 1, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(bEdit, 0, 7);
            tableLayoutPanel3.Controls.Add(bDel, 0, 8);
            tableLayoutPanel3.Controls.Add(bSearch, 0, 11);
            tableLayoutPanel3.Controls.Add(tbAutorS, 1, 11);
            tableLayoutPanel3.Controls.Add(label7, 1, 10);
            tableLayoutPanel3.Controls.Add(bAdd, 0, 6);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.ForeColor = SystemColors.Highlight;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 12;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.818793F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.614095F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.19956064F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.817216F));
            tableLayoutPanel3.Size = new Size(314, 363);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 501);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(940, 520);
            Name = "Form1";
            Text = "XML BD";
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdmin;
        private Button bDow;
        private Button bSet;
        private Button bClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbAutor;
        private TextBox tbName;
        private TextBox tbYear;
        private TextBox tbIZD;
        private TextBox tbJanr;
        private TextBox tbCount;
        private Button bAdd;
        private Button bEdit;
        private Button bDel;
        private DataGridViewTextBoxColumn colAutor;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colIZD;
        private DataGridViewTextBoxColumn colJanr;
        private DataGridViewTextBoxColumn colCount;
        private Button bSearch;
        private Label label7;
        private TextBox tbAutorS;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}