using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup 
    {
        public Popup()
        {
            InitializeComponent();
        }
        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text)))
                    {
                    PopupNavigation.Instance.PopAsync();
                    Navigation.PushAsync(new SignUp());
                }
                else
                {
                    DisplayAlert("Missing Fields", "Please fill all fields ", "OK");
                }
            }
            catch (Exception ex)
            {
                 DisplayAlert("Missing Fields", "Please fill all fields ", "OK");

            }
            //NavigationPage(new signup());

        }
    }
}