using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prorata.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double loyer;
        public double Loyer
        {
            get
            {
                return loyer;
            }
            set
            {
                if (value != loyer)
                {
                    loyer = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Loyer"));
                }
            }
        }

        private double salaire1;
        public double Salaire1
        {
            get
            {
                return salaire1;
            }
            set
            {
                if (value != salaire1)
                {
                    salaire1 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Salaire1"));
                }
            }
        }

        private double salaire2;
        public double Salaire2
        {
            get
            {
                return salaire2;
            }
            set
            {
                if (value != salaire2)
                {
                    salaire2 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Salaire2"));
                }
            }
        }

        private double montant1;
        public double Montant1
        {
            get
            {
                return montant1;
            }
            set
            {
                if (value != montant1)
                {
                    montant1 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Montant1"));
                }
            }
        }

        private double montant2;
        public double Montant2
        {
            get
            {
                return montant2;
            }
            set
            {
                if (value != montant2)
                {
                    montant2 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Montant2"));
                }
            }
        }
    }
}
