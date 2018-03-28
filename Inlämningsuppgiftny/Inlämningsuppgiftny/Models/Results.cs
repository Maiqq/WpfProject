using System;
using System.ComponentModel;

namespace Inlämningsuppgiftny
{
    class Results : INotifyPropertyChanged, IComparable<Results>
    {
        public Results(int round, double result, int nr)
        {
            _Round = round;
            _Result = result;
            _Nr = nr;
        }
        public Results()
        {
        }

        public int _Round { get; set; }
        public int Round

        {
            get { return _Round; }
            set
            {
                if (_Round != value)
                {
                    _Round = value;
                    RaisePropertyChanged("Round");
                }
            }
        }


        public double _Result { get; set; }
        public double Result

        {
            get { return _Result; }
            set
            {
                if (_Result != value)
                {
                    _Result = value;
                    RaisePropertyChanged("Result");
                }
            }
        }


        public int _Nr { get; set; }
        public int Nr

        {
            get { return _Nr; }
            set
            {
                if (_Nr != value)
                {
                    _Nr = value;
                    RaisePropertyChanged("Nr");
                }
            }
        }
        public string _End { get; set; }
        public string End
        {
            get { return _End; }
            set
            {
                if (_End!=value)
                {
                    _End = value;
                    RaisePropertyChanged("End");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

          public override string ToString()
           {
               string output = "Round: " + _Round + ", Results: " + _Result;

               return output;
           }
           
        public int CompareTo(Results other)
         {
             return other._Result.CompareTo(this._Result);
         }
        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

    }
}

