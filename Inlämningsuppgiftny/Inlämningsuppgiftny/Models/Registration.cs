using System;
using System.ComponentModel;

namespace Inlämningsuppgiftny
{
    class Registration : INotifyPropertyChanged, IComparable<Registration>
    {
        public Registration(string CompetitorName, string Gender, int Age, int nr, RegistrationType Types)
        {
            _CompetitorName = CompetitorName;
            _Gender = Gender;
            _Age = Age;
            _Nr = nr;
            Type = Types;
            Max = 0;
        }
        public Registration()
        { }



        string _CompetitorName;
        public string CompetitorName
        {
            get { return _CompetitorName; }
            set
            {
                if (_CompetitorName != value)
                {
                    _CompetitorName = value;
                    RaisePropertyChanged("CompetitorName");
                }
            }
        }
        string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (_Gender != value)
                {
                    _Gender = value;
                    RaisePropertyChanged("Gender");
                }
            }
        }
        int _Age;


        public int Age

        {
            get { return _Age; }
            set
            {
                if (_Age != value)
                {
                    _Age = value;
                    RaisePropertyChanged("Age");
                }
            }
        }

        public RegistrationType Type { get; set; }
        public int _Nr;
        public int Nr
        {
            get { return _Nr; }
            set
            {
                if(_Nr!=value)
                {
                    _Nr = value;
                    RaisePropertyChanged("Nr");
                }
            }
        }
        
        
        public double Max { get; set; }
       

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public int CompareTo(Registration other)
        {
            return other.Max.CompareTo(this.Max);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

