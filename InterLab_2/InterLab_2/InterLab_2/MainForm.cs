using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterLab_2
{
    public partial class MainForm : Form
    {
        //Форма настроек
        private ModalForm modalForm;
        public MainForm()
        {
            modalForm= new ModalForm();
            InitializeComponent();
            //Флаг включен.
            FlagLabel.Enabled = true;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            statuStrip.Text = ((MainForm)sender).Name;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //Создание экземпляра модальной формы и отображение его как модального диалога.
            ModalForm modalForm = new ModalForm(this.FlagLabel);

            //Открытие диалогового окна
            modalForm.ShowDialog();

            //Обработка нажатия ОК на модульном окне
            if (modalForm.DialogResult== DialogResult.OK)
            {
                //Перенос значений параметров статусной строки из модульного окна в основное с помощью get
                FlagLabel.Text = modalForm.FieldText;
                FlagLabel.TextAlign = modalForm.FieldAligment;
                FlagLabel.Enabled = modalForm.IsEnable;
                FlagLabel.BorderStyle = modalForm.FieldBorderStyle;
            }
        }
    }
}
