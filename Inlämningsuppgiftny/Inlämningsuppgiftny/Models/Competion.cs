using System;
using System.ComponentModel;

namespace Inlämningsuppgiftny
{

    class Competion : INotifyPropertyChanged

        {
            string _Name;
            public string Name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    if (_Name != value)
                    {
                        _Name = value;
                        RaisePropertyChanged("Name");
                    }
                }
            }

            DateTime _Date;
            public string Date
            {
                get
                {
               
                    return _Date.ToShortDateString();
                }
                set
                {
                    if (_Date != DateTime.Parse(value))
                    {
                        _Date = DateTime.Parse(value);
                        RaisePropertyChanged("Date");
                    }
                }
            }

            string _Address;
            public string Address
            {
                get
                {
                    return _Address;
                }
                set
                {
                    if (_Address != value)
                    {
                        _Address = value;
                        RaisePropertyChanged("Address");
                    }
                }
            }
        int _Round;
        public int Round
        {
            get
            {
                return _Round;
            }
            set
            {
                if(_Round!= value)
                {
                    _Round = value;
                    RaisePropertyChanged("Round");
                }
            }
        }

            void RaisePropertyChanged(string prop)
            {
                if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }

