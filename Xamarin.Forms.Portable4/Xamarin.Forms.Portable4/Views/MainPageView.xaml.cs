using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.Forms.Portable4.Views
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //await Navigation.PushAsync(new EntryPage(sender, e));

        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //this.Navigation.PushAsync(new EntryPage(e));
            //Navigation.PopAsync();
            //DisplayAlert("Item Tapped", item.ToString(), "Ok");

        }


    }
}
