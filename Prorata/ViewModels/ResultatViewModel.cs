using Prorata.Views;
using System;
using Xamarin.Forms;

namespace Prorata.ViewModels
{
    class ResultatViewModel : BaseViewModel
    {
        public Command HomePageCommand { get; set; }
        public double somme;
        public double pourcentage1;
        public double pourcentage2;

        public ResultatViewModel(double Loyer, double Salaire1, double Salaire2)
        {            
            HomePageCommand = new Command(() => ExecuteHomePageCommand());
            Calcul(Loyer, Salaire1, Salaire2);            
        }

        private void ExecuteHomePageCommand()
        {
            Application.Current.MainPage = new HomePage();
        }

        private void Calcul(double loyer, double salaire1, double salaire2)
        {
            somme = salaire1 + salaire2;

            pourcentage1 = salaire1 * (100 / somme);
            pourcentage2 = salaire2 * (100 / somme);

            Montant1 = Math.Round((loyer * (pourcentage1 / 100)), 1);
            Montant2 = Math.Round((loyer * (pourcentage2 / 100)), 1);

            Salaire1 = salaire1;
            Salaire2 = salaire2;
        }
    }
}
