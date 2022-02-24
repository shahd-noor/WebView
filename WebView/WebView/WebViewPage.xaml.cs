using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        //    BrowserLink.source = "https://www.google.com/";
        }
        private void Add_Clicked(object sender ,EventArgs e)
        {
            if (string.IsNullOrEmpty(WebLink.Text))
            {
                DisplayAlert("Warning", "Please enter webLink", "Ok");
                    return;

            }
            string.Url = "https://" + WebLink.Text;
            BrowserLink.Source = Url;

        }
    }
}