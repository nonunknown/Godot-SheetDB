using System;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Godot;

namespace Sheets
{
	static class SheetDB 
	{
		public static string apiUrl = "";
        // public static string apiKey = ""; TODO: add api key security system

        static HttpClient client = new HttpClient();


        public static async Task<String> GetFullApi() {
			string body = null;
			await ConfigClient();
			try
			{
				HttpResponseMessage response = await client.GetAsync(apiUrl);
				if (response.IsSuccessStatusCode) {
					body = await response.Content.ReadAsStringAsync();
				}else
				{
					throw new HttpRequestException(response.ReasonPhrase.ToString());
				}
			}
			catch (HttpRequestException e)
			{
				GD.Print("Error at sending request to full API");
				GD.Print(apiUrl);
				GD.Print(e.Message);
			}
			
			
			return body;
		}

		//POST EXAMPLE
		// public async Task<HttpResponseMessage> CreateUser(string ID, System.Object model) {
			
		// 	string response = "null";
		// 	var strContent = new StringContent(JsonConvert.SerializeObject(model),System.Text.Encoding.UTF8,"application/json");
		// 	HttpResponseMessage msg = await client.PostAsync(apiUrl,strContent);
		// 	if (msg.IsSuccessStatusCode) {
		// 		response = await msg.Content.ReadAsStringAsync();
		// 	}
		// 	return msg;
		// }

		static async Task ConfigClient() {
			GD.Print("Running Client Config");
			client.BaseAddress = new Uri(apiUrl);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
				new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
			);
			
		}
	}
}
