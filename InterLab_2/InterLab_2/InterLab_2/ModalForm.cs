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
    public partial class ModalForm : Form
    {
        private readonly Label flagLabel;

        public ModalForm()
        {
            InitializeComponent();
        }

        public ModalForm(Label flagLabel)
        {
            InitializeComponent();

            //Перенос параметров из основного окна
            flagLabelText.Text = flagLabel.Text;

            switch (flagLabel.BorderStyle.ToString())
            {
                case "None": 
                    rbNone.Checked = true;
                    break;
                case "Fixed3D": 
                    rbFix3D.Checked = true;
                    break;
                default: 
                    rbFixS.Checked = true;
                    break;
            }

            switch (flagLabel.TextAlign.ToString())
            {
                case "MiddleLeft": 
                    rbLeft.Checked = true;
                    break;
                case "MiddleRight": 
                    rbRight.Checked = true;
                    break;
                default: rbCentral.Checked = true;
                    break;
            }

            chkEnable.Checked = flagLabel.Enabled;

            this.flagLabel = flagLabel;
            // Инициализация чекбоксов в соответствии с текущими значениями DateTimePicker
        }

        public string FieldText
        {
            get { return flagLabelText.Text; }
        }

        //<summary>
        //Значение свойства Enable для текста.
        //<summary>
        public bool IsEnable
        {
            get
            {
                if (chkEnable.Checked)
                    return true;
                else
                    return false;
            }
        }

        //<summary>
        //Значение свойства FieldAligment для текста.
        //<summary>
        public ContentAlignment FieldAligment
        {
            get
            {
                var textAlign = groupBoxAlign.Controls.OfType<RadioButton>()
                            .FirstOrDefault(n => n.Checked).Text;
                switch (textAlign)
                {
                    case "Слева": return ContentAlignment.MiddleLeft;
                    case "Справа": return ContentAlignment.MiddleRight;
                    default: return ContentAlignment.MiddleCenter;
                }
            }
        }

        //<summary>
        //Значение свойства FieldBorderStyle для текста.
        //<summary>
        public BorderStyle FieldBorderStyle
        {
            get
            {
                var textAlign = groupBoxStyle.Controls.OfType<RadioButton>()
                            .FirstOrDefault(n => n.Checked).Text;
                switch (textAlign)
                {
                    case "FixedSingle": return BorderStyle.FixedSingle;
                    case "Fixed3D": return BorderStyle.Fixed3D;
                    default: return BorderStyle.None;
                }
            }
        }
    }
}
