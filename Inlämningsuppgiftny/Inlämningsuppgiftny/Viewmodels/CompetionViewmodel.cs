namespace Inlämningsuppgiftny
{
    class CompetionViewmodel : Base

    {
        #region Constructors
        public Competion Competion { get; set; }
        public RelayCommand AddCompetionCommand { get; set; }
        public Competion Newcomp { get; set; }
        public RelayCommand ResetFieldsCommand { get; set; }
        public RelayCommand ToRegistrationCommand { get; set; }

        public CompetionViewmodel()
        {
            Competion = new Competion() { Round = 3 }; ;
            Newcomp = new Competion();
            

            AddCompetionCommand = new RelayCommand(AddCompetion);
            ResetFieldsCommand = new RelayCommand(ResetFields);
            ToRegistrationCommand = new RelayCommand(ToRegistration);
        }
        #endregion

        #region Buttons
        void AddCompetion(object parameter)
        {
            if (Competion.Name == null) return;
            else if (Competion.Address == null) return;
            else if (Competion.Date == null) return;
            else if(Competion.Round==0)
            {
                Competion.Round = 3;
            }

            else
            {
                { Newcomp.Name = Competion.Name; Newcomp.Date = Competion.Date; Newcomp.Address = Competion.Address;Newcomp.Round = Competion.Round; }
                Competion.Name = "";
                Competion.Date = "1.1.0001";
                Competion.Address = "";
            }
        }
        void ResetFields(object parameter)
        {
            
            Competion.Name = "";
            Competion.Date = "1.1.0001";
            Competion.Address = "";
        }
        void ToRegistration(object parameter)
        {
            if (Newcomp.Name ==null)
            {
                return;
            }
            else
            {
                var win = new Window1 { DataContext = new RegistrationViewmodel(Newcomp.Name, Newcomp.Date, Newcomp.Address, Newcomp.Round) };
                win.Show();
                CloseWindow();
            }
        }

        #endregion

    }
}
