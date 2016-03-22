using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace fo_library.Choosing
{
    public partial class SignStringValueChoosingForm : Form, ISignValueChoosingForm<string>
    {
        #region Events

        public event EventHandler<EventArg<string>> SignValueChosen;

        #endregion
        public SignStringValueChoosingForm()
        {
            InitializeComponent();
        }



        public void SetSignValues(string[] signValues, string selectedSignValue)
        {
            this._BindingSourceSignValues.DataSource = signValues;

            if (selectedSignValue != null)
            {
                _BindingSourceSignValues.Position = Array.IndexOf(signValues, selectedSignValue);
            }
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        public void SetViewActionName(string actionName)
        {
            this.label1.Text = actionName;
        }

        public void ShowView()
        {
            this.ShowDialog();
        }

        private void _BtnOk_Click(object sender, EventArgs e)
        {
            var handler = this.SignValueChosen;
            if (handler != null)
            {
                string currentSignValue = _BindingSourceSignValues.Current as string;
                handler(null, new EventArg<string>(currentSignValue));
            }
        }

      
    }
}

