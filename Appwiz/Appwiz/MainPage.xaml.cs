using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appwiz
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
      
          
		}


        private async void Button_OnClicked(object sender, EventArgs e)
        {


            //var result = await DisplayAlert("Confirmation","Do want to proceed?","No","Yes");
            //if (result.Equals(obj : true))
            //{
            //    await Navigation.PushAsync(new SubPage());
            //}
            var result = await DisplayAlert("Confirmtion", "Do You Want To Proceed?","Yes","No");
            if (result.Equals(true))
            {
                await Navigation.PushAsync(new SubPage());
            }
               
        }

        //private async void button_OnclickAsync(object sender, EventArgs e)
        //{
        //    //Device.BeginInvokeOnMainThread(async () => {
        //    //    var result = await this.DisplayAlert("Alert!", "Do you really want to continue?", "Yes", "No");
        //    //    if (result) await Navigation.PushAsync(new Sample()); // or anything else
        //    //});
        //    //return true;

        //    var result = await DisplayAlert("title", "Hello", "OK", "Cancel");
        //    if (result.Equals(true))
        //    {
        //        await Navigation.PushAsync(new Sample());
        //    }
        //}

    }
}
