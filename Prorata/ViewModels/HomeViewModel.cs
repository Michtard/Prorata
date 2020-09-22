using Prorata.Views;
using Xamarin.Forms;

namespace Prorata.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public Command ResultatPageCommand { get; set; }

        public HomeViewModel()
        {
            ResultatPageCommand = new Command(() => ExecuteResultatPageCommand());
        }

        private void ExecuteResultatPageCommand()
        {
            Application.Current.MainPage = new ResultatPage(Loyer, Salaire1, Salaire2);            
        }
    }
}
