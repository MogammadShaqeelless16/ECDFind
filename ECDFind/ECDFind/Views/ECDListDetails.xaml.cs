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
    public partial class ECDListDetails : ContentPage
    {
        public ECDListDetails(string Name , string Number, string Email , string Details, string Cost )
        {
        InitializeComponent();

            ECDName.Text = Name;
            ECDNumber.Text = Number;
            ECDEmail.Text = Email;
            ECDDetails.Text = Details;
            ECDCost.Text = Cost;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}