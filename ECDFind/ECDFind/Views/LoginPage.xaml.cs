using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ECDFind.Tables;

namespace ECDFind.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }




        async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrationPage());

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "UserDatabase.db"); //Call Database  
            var db = new SQLiteConnection(dbPath);
            var myquery = db.Table<RegUserTable>().Where(x => x.UserName.Equals(EntryUser.Text) && x.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if(myquery!=null)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");
                    if (result)
                        await Navigation.PushModalAsync(new LoginPage());
                    else
                    {
                        await Navigation.PushModalAsync(new LoginPage());
                    }
                });
            }
        }
    }
}