using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

using Xamarin.Forms;

namespace novemob
{
	public partial class AddressPage : ContentPage
	{
		public AddressPage()
		{
			InitializeComponent();
		}

		async void CEP_Unfocused(object sender, Xamarin.Forms.FocusEventArgs e)
		{
			string sUrl = "https://viacep.com.br/ws/{0}/json/";

			HttpClient client = new HttpClient();
			var uri = new Uri(string.Format(sUrl, txtCEP.Text));
			var response = await client.GetAsync(uri);

			CEPResult cep = new CEPResult();

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();

				cep = JsonConvert.DeserializeObject<CEPResult>(content);

				txtStreet.Text = cep.Rua;
				txtCity.Text = cep.Cidade;
				txtState.Text = cep.UF;
				txtNeighborhood.Text = cep.Bairro;

				txtNumber.Focus();
			}
		}
	}
}

