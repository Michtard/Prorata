using Prorata.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prorata.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultatPage : ContentPage
    {
        public ResultatPage(double Loyer, double Salaire1, double Salaire2)
        {
            InitializeComponent();

            BindingContext = new ResultatViewModel(Loyer, Salaire1, Salaire2);
        }
    }
}