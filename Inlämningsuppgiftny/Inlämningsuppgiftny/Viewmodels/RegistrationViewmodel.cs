using System.Collections.ObjectModel;

namespace Inlämningsuppgiftny
{
    class RegistrationViewmodel:Base
    {
        public ObservableCollection<Registration> Newcomp1 {
            get; set; }
        public Competion Newcomp { get; set; }
        public Registration Registration { get; set; }
        public ObservableCollection<string> Gender { get; private set; }
        
         public RelayCommand AddCompetitorCommand { get; set; }
        public RelayCommand ResetFieldsCommand { get; set; }
        public RelayCommand StartCompetionCommand { get; set; }
        public
       object _SelectedPerson;
        public object SelectedPerson
        {
            get
            {
                return _SelectedPerson;
            }
            set
            {
                if (_SelectedPerson != value)
                {
                    _SelectedPerson = value;
                    RaisePropertyChanged("SelectedPerson");
                }
            }
        }


        public RegistrationViewmodel(string CompetionName, string Date, string Address, int Round)
        {
            Newcomp = new Competion() { Name = CompetionName, Date = Date, Address = Address, Round = Round };
            Registration = new Registration();
            Newcomp1 = new ObservableCollection<Registration>();
            AddCompetitorCommand = new RelayCommand(AddCompetitor);
            ResetFieldsCommand = new RelayCommand(ResetFields);
            StartCompetionCommand = new RelayCommand(StartCompetion);

            Gender = new ObservableCollection<string>
            {
                "Male",
                "Female",
                "Other"

            };

    }
        #region Buttons
        void ResetFields(object parameter)
        {

            Registration.CompetitorName = "";
            Registration.Age = 0;
            Registration.Gender = "";
        }

        int nr = 1;
        void AddCompetitor(object parameter)
        {
            
            if (parameter == null) return;

            if (Registration.Gender == "Male")
            {
                if (Registration.Age < 18)
                {
                    Registration.Type = RegistrationType.Boys;

                }
                else Registration.Type = RegistrationType.Men;
            }
            else if (Registration.Age < 18)
            {
                Registration.Type = RegistrationType.Girls;
            }
            else Registration.Type = RegistrationType.Women;
            if (Registration.CompetitorName == null) return;
            else if (Registration.Gender == null) return;
            else if (Registration.Age <= 0) return;
            else
            {
                Newcomp1.Add(new Registration(Registration.CompetitorName, Registration.Gender, Registration.Age, nr, Registration.Type));
            }
            
            
            nr++;
          
        }
        void StartCompetion(object parameter)
        {
            var win = new Window2 { DataContext = new StartCompetionViewmodel(Newcomp1, Newcomp.Name, Newcomp.Date, Newcomp.Address, Newcomp.Round) };
            win.Show();
            CloseWindow();
        }
        #endregion
    }
}
