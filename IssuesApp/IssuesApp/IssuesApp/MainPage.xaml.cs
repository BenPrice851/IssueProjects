using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IssuesApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainPage_ViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainPage_ViewModel();
            BindingContext = _viewModel;
        }
    }
}
