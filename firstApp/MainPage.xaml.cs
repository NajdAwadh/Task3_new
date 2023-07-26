using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace firstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /* void OnButtonClicked(object sender , EventArgs argd)
        {
            //await Label.RelRotateTo(360, 1000);
        }*/
        private  void Popup_Clicked(object sender, EventArgs e)
        {
             PopupNavigation.Instance.PushAsync(new Popup());////Popup()
        }
      
    }
}
