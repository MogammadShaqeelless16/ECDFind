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

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}