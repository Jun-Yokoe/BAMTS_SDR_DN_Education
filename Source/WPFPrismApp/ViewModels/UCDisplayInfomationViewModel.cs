using Prism.Commands;
using Prism.Commands;
using Prism.Services.Dialogs;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BAMTS.Internal
{
    public class UCDisplayInfomationViewModel : BindableBase, IDialogAware
    {
        private string _textInput = "";

        public event Action<IDialogResult> RequestClose;

        public string TextInput
        {
            get { return this._textInput; }
            set
            {
                SetProperty(ref this._textInput, value);
            }
        }
        public string Title => "Information";

        public UCDisplayInfomationViewModel()
        {
        }
        public bool CanCloseDialog()
        {
            return true;
        }
        public void OnDialogClosed()
        {
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
