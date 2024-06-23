using Discord093.Models;
using Discord093.Rest.Endpoints;
using System.Net.Http.Headers;

namespace Discord093.Rest;

public class Discord093Rest
{
	public HttpClient HttpClient { get; } = new HttpClient();
	public UsersEndpoint Users { get; }

	public Discord093Rest(Token token)
	{
		this.HttpClient.BaseAddress = new Uri("https://discord.com/api/v10/");
		this.HttpClient.DefaultRequestHeaders.Authorization =
			new AuthenticationHeaderValue(token.Type.ToString(), token.Value);

		this.Users = new UsersEndpoint(this);
	}
}
