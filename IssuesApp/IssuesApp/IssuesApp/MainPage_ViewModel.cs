using IssuesApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IssuesApp
{
    public class MainPage_ViewModel : BaseViewModel
    {
        public MainPage_ViewModel()
        {
            BindableClass = new CustomClass();
        }

        private CustomClass _bindableClass;
        public CustomClass BindableClass
        {
            get { return _bindableClass; }
            set
            {
                if (_bindableClass != value)
                {
                    _bindableClass = value;
                    OnPropertyChanged(nameof(BindableClass));
                }
            }
        }
    }
}
