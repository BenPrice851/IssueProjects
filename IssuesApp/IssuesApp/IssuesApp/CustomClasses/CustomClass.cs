using IssuesApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IssuesApp
{
    public class CustomClass : BaseViewModel
    {
        public CustomClass()
        {
            TakePhotoCommand = new Command(async () => await TakePhoto());
        }

        private async Task TakePhoto()
        {
            Result = await new PhotoManager().TakeNewPhoto();
        }

        public ICommand TakePhotoCommand { protected set; get; }

        private string _result;
        public string Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
    }
}
