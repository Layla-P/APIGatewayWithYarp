using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddHttpClient("FoodService", client =>
			{
				client.BaseAddress = new Uri("https://localhost:44378/");
			});

			builder.Services.AddHttpClient("DrinkService", client =>
			{
				client.BaseAddress = new Uri("https://localhost:44366/");
			});
			await builder.Build().RunAsync();
		}
	}
}
