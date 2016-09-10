using System;
using Newtonsoft.Json;
namespace novemob
{
	public class CEPResult
	{
		[JsonProperty("logradouro")]
		public string Rua { get; set; }

		[JsonProperty("complemento")]
		public string Complemento { get; set; }

		[JsonProperty("bairro")]
		public string Bairro { get; set; }

		[JsonProperty("localidade")]
		public string Cidade { get; set; }

		[JsonProperty("uf")]
		public string UF { get; set; }

		public CEPResult()
		{
			
		}
	}
}

