using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace novemob
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void loginClick(object sender, System.EventArgs e)
		{
			UserDialogs.Instance.ShowLoading("Logando como: " + txtLogin.Text);
			await Task.Delay(2000);

			await Navigation.PushAsync(new RegisterUsuarioPage());

			UserDialogs.Instance.HideLoading();
			//DisplayAlert("Login", txtPassword.Text, "OK", "Cancelar");
		}

		void recClick(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}

