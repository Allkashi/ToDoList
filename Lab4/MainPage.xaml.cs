using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            var itemsender = (Xamarin.Forms.Button)sender;
            var item = (Model)itemsender?.CommandParameter;
            var vm = BindingContext as ViewModel;
            vm.LIST.Remove(item);
        }
    }


}
