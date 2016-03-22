using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Choosing.SignChoosing.AbstractsAndGenerics.SignChoosing.View
{
    public partial class SignStringValueChoosingView : UserControl, ISignValueChoosingView<string>
    {
        public SignStringValueChoosingView()
        {
            InitializeComponent();
        }



        public event EventHandler<EventArg<string>> SignValueChosen;

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
            throw new NotImplementedException();
        }

        public void SetViewActionName(string actionName)
        {
            this.label1.Text = actionName;
        }

        public void ShowView()
        {
            throw new NotImplementedException();
        }

        public void ChooseSelectedSignValue()
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
