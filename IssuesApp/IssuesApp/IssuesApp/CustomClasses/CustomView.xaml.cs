using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IssuesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomView : ContentView
    {
        public CustomView()
        {
            InitializeComponent();
            //Content.BindingContext = ClassBinding;
        }

        //public static readonly BindableProperty ClassBindingProperty = BindableProperty.Create(
        //    nameof(ClassBinding),
        //    typeof(CustomClass),
        //    typeof(CustomView),
        //    default(CustomClass),
        //    defaultBindingMode: BindingMode.TwoWay);

        //public CustomClass ClassBinding
        //{
        //    get { return (CustomClass)GetValue(ClassBindingProperty); }
        //    set { SetValue(ClassBindingProperty, value); }
        //}
    }
}