namespace InterLab_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlagLabel = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.statuStrip = new System.Windows.Forms.StatusStrip();
            this.toolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlagLabel
            // 
            this.FlagLabel.Location = new System.Drawing.Point(95, 119);
            this.FlagLabel.Name = "FlagLabel";
            this.FlagLabel.Size = new System.Drawing.Size(316, 44);
            this.FlagLabel.TabIndex = 0;
            this.FlagLabel.Text = "Текст для применения свойств";
            this.FlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(212, 200);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 22);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Настроечки";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(92, 60);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(319, 13);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Щелкните по кнопке для задания свойств компонента Текст";
            // 
            // statuStrip
            // 
            this.statuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusLabel});
            this.statuStrip.Location = new System.Drawing.Point(0, 338);
            this.statuStrip.Name = "statuStrip";
            this.statuStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statuStrip.Size = new System.Drawing.Size(484, 22);
            this.statuStrip.TabIndex = 3;
            this.statuStrip.Text = "Информация";
            // 
            // toolStatusLabel
            // 
            this.toolStatusLabel.Name = "toolStatusLabel";
            this.toolStatusLabel.Size = new System.Drawing.Size(83, 17);
            this.toolStatusLabel.Text = "Информация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.statuStrip);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.FlagLabel);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.statuStrip.ResumeLayout(false);
            this.statuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlagLabel;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.StatusStrip statuStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusLabel;
    }
}

