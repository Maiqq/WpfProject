using System.Collections.ObjectModel;

namespace Inlämningsuppgiftny
{
    class StartCompetionViewmodel:Base
        
    {
        public Competion Newcomp { get; set; }
        public ObservableCollection<Registration> Newcomp2 { get; set; }
       public ObservableCollection<Results> Resultlist { get; set; }
        public Results Results { get; set; }
        public Registration Registration { get; set; }
        public RelayCommand AddResultsCommand { get; set; }

      




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
        public StartCompetionViewmodel(ObservableCollection<Registration> Newcomp1,string CompetionName, string Date, string Address, int Round)
        {
        Newcomp = new Competion() { Name = CompetionName, Date = Date, Address = Address, Round= Round };
            Newcomp2 = Newcomp1;
            Resultlist = new ObservableCollection<Results>();
            Results = new Results();
            Results.Round = 1;
            Registration = new Registration();
            AddResultsCommand = new RelayCommand(AddResults);
            Registration.Nr = 1;

            Results.End = "Competion is ongoing";

        }

       
        int i = 0;
        
        void AddResults(object parameter)

        {
            {
                if (parameter == null) return;
                if (Results.Round <= Newcomp.Round)
                {

                    Registration.Nr = Newcomp2[i].Nr;

                    Resultlist.Add(new Results(Results.Round, Results.Result, (Registration.Nr)));
                    i++;
                   
                    if (i == Newcomp2.Count)
                    {
                        Results.Round++;
                        i = 0;
                    }
                    Registration.Nr = Newcomp2[i].Nr;
                } 
                else
                {

                    Results.End = "Competion is over!";
                         return;
                }
                
            }

        }
        
    }
}
