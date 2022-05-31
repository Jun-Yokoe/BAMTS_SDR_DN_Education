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
        public DelegateCommand OKButton_Click { get; }

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
            this.OKButton_Click = new DelegateCommand(this.OKButton_Execute);
        }
        private void OKButton_Execute()
        {
            var p = new DialogParameters();
            p.Add(nameof(UCDisplayInfomationViewModel.TextInput), this.TextInput);
            this.RequestClose?.Invoke(new DialogResult(ButtonResult.OK, p));
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
            this.TextInput = parameters.GetValue<string>(nameof(UCDisplayInfomationViewModel.TextInput));
        }
    }
}
