using System.Windows.Forms;

namespace InterLab_2
{
    public partial class ModalForm : Form
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalForm));
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxAlign = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbCentral = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.rbFix3D = new System.Windows.Forms.RadioButton();
            this.rbFixS = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.LabelForLabel = new System.Windows.Forms.Label();
            this.flagLabelText = new System.Windows.Forms.TextBox();
            this.groupBoxAlign.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Checked = true;
            this.chkEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnable.Location = new System.Drawing.Point(28, 289);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(59, 17);
            this.chkEnable.TabIndex = 0;
            this.chkEnable.Text = "Enable";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(28, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(183, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(6, 19);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(56, 17);
            this.rbLeft.TabIndex = 3;
            this.rbLeft.Text = "Слева";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlign
            // 
            this.groupBoxAlign.Controls.Add(this.rbRight);
            this.groupBoxAlign.Controls.Add(this.rbCentral);
            this.groupBoxAlign.Controls.Add(this.rbLeft);
            this.groupBoxAlign.Location = new System.Drawing.Point(28, 170);
            this.groupBoxAlign.Name = "groupBoxAlign";
            this.groupBoxAlign.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAlign.TabIndex = 4;
            this.groupBoxAlign.TabStop = false;
            this.groupBoxAlign.Text = "Text Align";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(6, 65);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(62, 17);
            this.rbRight.TabIndex = 5;
            this.rbRight.Text = "Справа";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbCentral
            // 
            this.rbCentral.AutoSize = true;
            this.rbCentral.Checked = true;
            this.rbCentral.Location = new System.Drawing.Point(6, 42);
            this.rbCentral.Name = "rbCentral";
            this.rbCentral.Size = new System.Drawing.Size(56, 17);
            this.rbCentral.TabIndex = 4;
            this.rbCentral.TabStop = true;
            this.rbCentral.Text = "Центр";
            this.rbCentral.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.rbFix3D);
            this.groupBoxStyle.Controls.Add(this.rbFixS);
            this.groupBoxStyle.Controls.Add(this.rbNone);
            this.groupBoxStyle.Location = new System.Drawing.Point(28, 64);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(200, 100);
            this.groupBoxStyle.TabIndex = 6;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Border Style";
            // 
            // rbFix3D
            // 
            this.rbFix3D.AutoSize = true;
            this.rbFix3D.Location = new System.Drawing.Point(6, 65);
            this.rbFix3D.Name = "rbFix3D";
            this.rbFix3D.Size = new System.Drawing.Size(64, 17);
            this.rbFix3D.TabIndex = 5;
            this.rbFix3D.Text = "Fixed3D";
            this.rbFix3D.UseVisualStyleBackColor = true;
            // 
            // rbFixS
            // 
            this.rbFixS.AutoSize = true;
            this.rbFixS.Location = new System.Drawing.Point(6, 42);
            this.rbFixS.Name = "rbFixS";
            this.rbFixS.Size = new System.Drawing.Size(79, 17);
            this.rbFixS.TabIndex = 4;
            this.rbFixS.Text = "FixedSingle";
            this.rbFixS.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(6, 19);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 3;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // LabelForLabel
            // 
            this.LabelForLabel.AutoSize = true;
            this.LabelForLabel.Location = new System.Drawing.Point(28, 25);
            this.LabelForLabel.Name = "LabelForLabel";
            this.LabelForLabel.Size = new System.Drawing.Size(37, 13);
            this.LabelForLabel.TabIndex = 7;
            this.LabelForLabel.Text = "Текст";
            // 
            // flagLabelText
            // 
            this.flagLabelText.Location = new System.Drawing.Point(69, 22);
            this.flagLabelText.Name = "flagLabelText";
            this.flagLabelText.Size = new System.Drawing.Size(189, 20);
            this.flagLabelText.TabIndex = 8;
            this.flagLabelText.Text = "Текст для применения свойств";
            // 
            // ModalForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.flagLabelText);
            this.Controls.Add(this.LabelForLabel);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxAlign);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.chkEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задайте параметры текста";
            this.groupBoxAlign.ResumeLayout(false);
            this.groupBoxAlign.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkEnable;
        private Button buttonOK;
        private Button buttonCancel;
        private RadioButton rbLeft;
        private GroupBox groupBoxAlign;
        private RadioButton rbRight;
        private RadioButton rbCentral;
        private GroupBox groupBoxStyle;
        private RadioButton rbFix3D;
        private RadioButton rbFixS;
        private RadioButton rbNone;
        private Label LabelForLabel;
        private TextBox flagLabelText;
    }
}