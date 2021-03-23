using ECDFind.Models;
using ECDFind.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ECDFind.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ECDListPage : ContentPage
    {
        public ECDListPage()
        {
            InitializeComponent();
            BindingContext = new ECDList_ViewModel();
        }

        private async void OnItemSelected(object sender , ItemTappedEventArgs e)
        {
            var details = e.Item as ECDListModel;
            await Navigation.PushModalAsync(new ECDListDetails(details.ECDName, details.ECDNumber, details.ECDEmail, details.ECDCost, details.ECDDetails));
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}