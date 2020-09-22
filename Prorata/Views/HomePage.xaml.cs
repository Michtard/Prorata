using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prorata.ViewModels;

namespace Prorata.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}