using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Lab4
{

    class Model:BindableObject
    {
        private string _Buying;

        public string Buying
        {
            get 
            { 
                return _Buying;
            }
            set 
            {
                _Buying = value;
                OnPropertyChanged (nameof(Buying));
            }
        }

        private int _Num;

        public int Num
        {
            get
            {
                return _Num;
            }
            set
            {
                _Num = value;
                OnPropertyChanged(nameof(Num));
            }
        }
        private string _Number;

        public string Number
        {
            get { return _Number; }
            set { _Number = value; OnPropertyChanged(nameof(Number)); }
        }

        private bool _IsCheck;

        public bool IsCheck
        {
            get { return _IsCheck; }
            set { _IsCheck = value; OnPropertyChanged(nameof(IsCheck)); }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
          
        }

        private Color _Colour;
        public Color Colour
        {
            get { return _Colour; }
            set { _Colour = value; OnPropertyChanged(nameof(Colour)); }
        }




    }
}
